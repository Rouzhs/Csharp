using System;
using System.Windows.Forms;
using System.IO;

namespace encryption
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void ButtonExitClick(object sender, EventArgs e)
    {
      Close();
    }

    private void buttonEncrypt_Click(object sender, EventArgs e)
    {
      string password = textBoxPassword.Text;
      string path = textBoxPath.Text;
      labelinfo.Text = "";
      if (password == "" || path == "")
      {
        labelinfo.Text = "Please enter all details";
        return;
      }
      if (!File.Exists(path))
      {
        labelinfo.Text = "File not found";
        return;
      }
      int N = Key.GetN(password);
      int E = Key.GetE();                                               //{E, N} - открытый ключ
      FileInfo fileInf = new FileInfo(path);
      string dir = fileInf.DirectoryName;
      string name = fileInf.Name;
      string newDir = dir + "\\" + "[ENCRYPTED]";                       //новая папка для разрешения конфликта имён:
      if (!Directory.Exists(newDir))                                    //(файлы с одинаковым названием в одной директории)
      {
        Directory.CreateDirectory(newDir);
      }
      string newFile = newDir + "\\" + name;
      using (FileStream fread = new FileStream(path, FileMode.Open))
      {
        byte[] array = new byte[fread.Length];
        fread.Read(array, 0, array.Length);                              //получили ascii код i-того символа файла в массив array
        var textlen = fread.Length;
        int[] newArray = new int[textlen];                               //i-тый элемент этого массива будет числом - шифр i-того символа исходного файла
        for (int i = 0; i < textlen; i++)
        {
          int symb = Convert.ToInt32(array[i]);
          int encryptSymb = 1;
          for (int j = 0; j < E; j++)
          {
            encryptSymb *= symb;
            encryptSymb %= N;
          }
          newArray[i] = encryptSymb;
        }
        using (StreamWriter fwrite = new StreamWriter(newFile))
        {
          for (int i = 0; i < textlen; i++)
          {
            fwrite.Write(newArray[i]);
            fwrite.Write(" ");
          }
          labelinfo.Text = "Success";
        }
      }
    }
    private void buttonDecrypt_Click(object sender, EventArgs e)
    {
      string password = textBoxPassword.Text;
      string path = textBoxPath.Text;
      labelinfo.Text = "";
      if (password == "" || path == "")
      {
        labelinfo.Text = "Please enter all details";
        return;
      }
      if (!File.Exists(path))
      {
        labelinfo.Text = "File not found";
        return;
      }
      var N = Key.GetN(password);
      var D = Key.GetD();                                                    //{D, N} - секретный ключ

      FileInfo fileInf = new FileInfo(path);
      string dir = fileInf.DirectoryName;
      string name = fileInf.Name;
      string newDir = dir + "\\" + "[DECRYPTED]";
      if (!Directory.Exists(newDir))
      {
        Directory.CreateDirectory(newDir);
      }
      string newFile = newDir + "\\" + name;
      using (StreamReader fread = new StreamReader(path))
      {
        string encrText = fread.ReadToEnd();                                 //строка из чисел через пробел (зашифрованный текст)
        byte[] newArray = new byte[encrText.Length];                         //encrText.Length заведомо больше нужного размера примерно в пять раз
        string numStr = "";
        int countNumbers = 0;
        for (int i = 0; i < encrText.Length; i++)
        {
          if (encrText[i] != ' ')                                           //можно также записать в строку и Split()'ом получить массив чисел
          {
            numStr += encrText[i];
          }
          else
          {
            long num = Convert.ToInt64(numStr);
            numStr = "";
            long decrSymb = 1;                                              //расшифрованный символ
            for (int j = 0; j < D; j++)
            {
              decrSymb *= num;
              decrSymb %= N;
            }
            if (decrSymb > 255)                                             //Byte.MaxValue == 255;
            {
              labelinfo.Text = "Wrong password";                            //для демонстрации просто вывод сообщения, но
              return;                                                       //можно при неверном пароле не сообщать это явно, а 
            }                                                               //записывать в файл decrSymb % 256, или рандомные символы 
            newArray[countNumbers] = Convert.ToByte(decrSymb);
            countNumbers++;                                                 //чтобы узнать, сколько именно символов из массива newArray записывать
          }
        }
        using (FileStream fwrite = new FileStream(newFile, FileMode.OpenOrCreate))
        {
          fwrite.Write(newArray, 0, countNumbers);
          labelinfo.Text = "Success";
        }
      }
    }
  }
}

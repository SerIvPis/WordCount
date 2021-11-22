using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCount
{
    public partial class Form1 : Form
    {
        private List<FileInfo> ListFiles = new List<FileInfo>( );
        private List<String> ListWorlds = new List<string>( );
        public Form1( )
        {
            InitializeComponent( );
        }

        private void btnOpenDir_Click( object sender, EventArgs e )
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lbListFiles.Items.Clear( );
                ListFiles.Clear( );
                DirectoryInfo rootDir = Directory.CreateDirectory( folderBrowserDialog1.SelectedPath );
                rootDir.Create( );
                foreach (FileInfo item in rootDir.GetFiles( "*.txt", SearchOption.TopDirectoryOnly ))
                {
                    ListFiles.Add( item );
                    lbListFiles.Items.Add( item.Name );
                }
                rbOrdeByQuantity.Checked = true;

            }
            
        }

        //Обработчик двойного щелчка по выбранному текстовому файлу
        private void lbListFiles_DoubleClick( object sender, EventArgs e )
        {
            
            if (lbListFiles.SelectedItem != null)
            {
                FileToWords( ListFiles[ lbListFiles.SelectedIndex ].FullName, ListWorlds );
                //CountWords( ListWorlds , rbOrdeByQuantity.Checked);
                ViewListStrings( new List<string>( CountWords( ListWorlds, rbOrdeByQuantity.Checked )), lbWords );
                label1.Text = $"Количество слов: {CountWords( ListWorlds, rbOrdeByQuantity.Checked ).Count( )}";
            }
        }

        private IEnumerable<string> CountWords( List<string> listWorlds, bool sortQuantity )
        {
            List<string> resultList = new List<string>( );
            var res = ListWorlds.Where( s => s.Length > 2 )
                   .GroupBy( s => s )
                   .Select( s => new
                   {
                       word = s.Key,
                       count = s.Count( )
                   } );
            if (sortQuantity)
            {
                foreach (var item in res.OrderByDescending(s => s.count))
                {
                    resultList.Add( $"{item.word} - {item.count}" );
                }
                return resultList;
            }
            foreach (var item in res.OrderBy( s => s.word ))
            {
                resultList.Add( $"{item.word} - {item.count}" );
            }
            return resultList;

        }

        private void ViewListStrings( List<string> listWorlds, ListBox _lbWords )
        {
            _lbWords.Items.Clear( );
            _lbWords.Items.AddRange( listWorlds.ToArray<string>( ) );
        }

        //Из файла в список слов
        private void FileToWords( string fullName , List<string> words)
        {
            words.Clear( );
            // Символы разделители
            //char[] separator =new char[] { '.', ' ', ',', ':', ';', '%','-','"', '\u2013','»', '«'
            //    ,'[',']','<','>','\r','\n',
            //                                ')','(', '\u0021', '\u0160', '\u0044',
            //                                '\u0013','?','!','&', '\u2026','\u0010'};

            char[] separator = new char[] { '\r','\n',' ','.',',','[',']','!','?',':',';','\u2014','\u2013'
                                            ,'\u00AB', '\u00BB'};

            //Считывает файл и разбиваем на слова
            string temp = File.ReadAllText( fullName, Encoding.GetEncoding( "windows-1251" ) );
            string[] txtToStringArray = File.ReadAllText( fullName, Encoding.GetEncoding( "windows-1251" ) )
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);

            //
            foreach (var item in txtToStringArray)
            {
                words.Add( item.ToLowerInvariant().Trim( ) );
            }
           
        }

      
        private void lbWords_DoubleClick( object sender, EventArgs e )
        {
            if (lbWords.SelectedItem != null)
            {
                string resultChars = "";
                foreach (var item in (string)lbWords.Items[ lbWords.SelectedIndex ])
                {
                    resultChars +=  $"{(int)item}\t";
                }
                MessageBox.Show( resultChars );
            }

        }

        private void rbOrdeByQuantity_CheckedChanged( object sender, EventArgs e )
        {
            ViewListStrings( new List<string>( CountWords( ListWorlds, rbOrdeByQuantity.Checked ) ), lbWords );
        }
    }
}

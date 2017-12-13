using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubTitleMaker.WPF
{
    public class MainWindowViewModel: Bases.BaseViewModel
    {
        private string _chineseText;

        public string ChineseText
        {
            get { return _chineseText; }
            set { SetField(ref _chineseText, value); }
        }
        private string _englishText;

        public string EnglishText
        {
            get { return _englishText; }
            set { SetField(ref _englishText, value); }
        }
        public MainWindowViewModel()
        { }
    }
}

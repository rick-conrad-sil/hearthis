using System.Collections.Generic;
using System.IO;
using Palaso.IO;
using System.Linq;

namespace HearThis.Script
{
	public class Project
	{
		//private readonly ScrText _paratextProject;
		private BookInfo _selectedBook;
		private ChapterInfo _selectedChapter;
//        public List<string> BookNames ;
//        public List<int> ChaptersPerBook;
//        private Dictionary<int, int[]> VersesPerChapterPerBook;
		public BibleStats Statistics;
		public List<BookInfo> Books { get; set; }
		private IScriptProvider _scriptProvider;


//        public Project(ScrText paratextProject)
//        {
//            Name = paratextProject.Name;
//            //_paratextProject = paratextProject;
//            Books = new List<BookInfo>();
//            LoadStatistics();
//            var chapterCounts = ChaptersPerBook.ToArray();
//
//
//            for (int bookNumber = 0; bookNumber < BookNames.Count(); ++bookNumber )
//            {
//                int bookNumberDelegateSafe = bookNumber;
//                var book = new BookInfo(bookNumber, BookNames.ElementAt(bookNumber), chapterCounts[bookNumber], VersesPerChapterPerBook[bookNumber]);
//                bookNumberDelegateSafe = bookNumber;
//                book.GetVerse = ((chapter, verse) => GetVerse(paratextProject, bookNumberDelegateSafe, chapter, verse));
//                Books.Add(book);
//            }
//            SelectedBook = Books.First();
//        }





		public Project(string name, IScriptProvider scriptProvider)
		{
			_scriptProvider = scriptProvider;

			Name = name;
			Books = new List<BookInfo>();
			Statistics = new BibleStats();

			var chapterCounts = Statistics.ChaptersPerBook.ToArray();

			for (int bookNumber = 0; bookNumber < Statistics.BookNames.Count(); ++bookNumber)
			{
				int bookNumberDelegateSafe = bookNumber;
				var book = new BookInfo(bookNumber, Statistics.BookNames.ElementAt(bookNumber), chapterCounts[bookNumber], Statistics.VersesPerChapterPerBook[bookNumber]);
				bookNumberDelegateSafe = bookNumber;
				book.GetLineMethod = ((chapter, line) => _scriptProvider.GetLine(bookNumberDelegateSafe, chapter, line));
				book.HasVersesMethod = ((chapter) => _scriptProvider.HasVerses(bookNumberDelegateSafe, chapter));
				Books.Add(book);
			}

			SelectedBook = Books.First();
		}

		public BookInfo SelectedBook
		{
			get { return _selectedBook; }
			set
			{
				if (_selectedBook != value)
				{
					_selectedBook = value;
					SelectedChapter = value.GetChapter(0);
				}
			}
		}

		public ChapterInfo SelectedChapter
		{
			get { return _selectedChapter; }
			set
			{
				if (_selectedChapter != value)
				{
					_selectedChapter = value;
					SelectedScriptLine = 1;
				}
			}
		}

		/// <summary>
		/// This  would be the verse, except there are more things than verses to read (chapter #, section headings, etc.)
		/// </summary>
		public int SelectedScriptLine { get; set; }

		public string Name { get; set; }

		public int GetLineCountForChapter()
		{
			return _scriptProvider.GetLineCountForChapter(_selectedBook.BookNumber,_selectedChapter.ChapterNumber);
		}
	}
}
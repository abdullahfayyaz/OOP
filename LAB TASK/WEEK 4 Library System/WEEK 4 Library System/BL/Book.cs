using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_4_Library_System.BL
{
    class Book
    {
        public string author;
        public int pages;
        public List<string> Chapters;
        public int bookMark;
        public int price;
        public Book()
        {

        }
        public Book(string author, int pages, List<string> Chapters, int price)
        {
            this.author = author;
            this.pages = pages;
            this.Chapters = Chapters;
            this.price = price;
        }
        public string getChapter(int chapterNo)
        {
            if (chapterNo < 1 && chapterNo > Chapters.Count)
            {
                return "invalid chapter name";
            }
            else
            {
                return Chapters[chapterNo - 1];
            }
        }
        public int getBookMark()
        {
            if (bookMark > -1)
            {
                return bookMark;
            }
            else
                return -1;
        }
        public void setBookPrice(int newPrice)
        {
            price = newPrice;
        }
        public int getPrice()
        {
            return price;
        }
        public void setBookMark(int bookMark)
        {
            this.bookMark = bookMark;
        }
    }
}

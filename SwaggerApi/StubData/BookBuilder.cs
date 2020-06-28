using SwaggerApi.Common;
using System;

namespace SwaggerApi.StubData
{
    public class BookBuilder : Book
    {
        public BookBuilder(Guid? id)
        {
            this.Id = id ?? Guid.NewGuid();
        }

        public void AddFormat(BookFormat format)
        {
            this.AvailableFormats = this.AvailableFormats ?? new System.Collections.Generic.List<BookFormat>();

            if (!this.AvailableFormats.Contains(format))
            {
                this.AvailableFormats.Add(format);
            }
        }

        public BookBuilder FiveDysfunctionsOfATeam()
        {
            this.Title = "The Five Dysfunctions of a Team";
            this.Author = "Patrick Lencioni";
            this.ReleaseDate = new DateTime(2002, 01, 01);

            AddFormat(BookFormat.Hardcover);
            AddFormat(BookFormat.Ebook);
            AddFormat(BookFormat.Audiobook);

            return this;
        }

        public BookBuilder PhoenixProject()
        {
            this.Title = "The Phoenix Project";
            this.Author = "Gene Kim and George Spafford and Kevin Behr";
            this.ReleaseDate = new DateTime(2013, 01, 01);

            AddFormat(BookFormat.Hardcover);
            AddFormat(BookFormat.Ebook);

            return this;
        }

        public BookBuilder RadicalCandor()
        {
            this.Title = "Radical Candor";
            this.Author = "Kim Scott";
            this.ReleaseDate = new DateTime(2017, 01, 01);

            AddFormat(BookFormat.Hardcover);
            AddFormat(BookFormat.Audiobook);

            return this;
        }

        public Book Build()
        {
            return this;
        }
    }
}
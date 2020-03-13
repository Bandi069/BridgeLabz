
using Model.NoteModel;
using NUnit.Framework;
using Repository.Repository;

namespace NUnitTestFundoo
{
    [TestFixture]
   public class NoteTestCase
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void AddNote()
        {
            NoteRepository noteRepository = new NoteRepository();
            Notemodel noteModel = new Notemodel()
            {
                NoteID = 123,
                Emailid = "bandivenu89@gmail.com",
                Title = "title",
                Description = "descrip",
                Archive = "archieved",
                AddImg = "NewImage",
                AddColor = "Red",
                Remainder = "remaindeme",
                Trash = true,
                PinNote = true,
            };
            Assert.IsNotNull(noteRepository.AddNote(noteModel));
        }
        [Test]
        public void Deletenote()
        {
            NoteRepository noterepository = new NoteRepository();
            var notemodel = new Notemodel();
            notemodel.NoteID = 1245;
            Assert.IsNotNull(noterepository.DeleteNote(1245));
        }
        [Test]
        public void Updatenote()
        {
            NoteRepository noterepository = new NoteRepository();
            Notemodel notemodel = new Notemodel()
            {
                NoteID = 1245,
                Emailid = "bandivenu89@gmail.com",
                Title = "title",
                Description = "descrip",
                Archive = "archieved",
                AddImg = "NewImage",
                AddColor = "Red",
                Remainder = "remaindeme",
                Trash = true,
                PinNote = true,
            };
            Assert.IsNotNull(noterepository.UpdateNote(notemodel));
        }
        [Test]
        public void Getnote()
        {
            NoteRepository noterepository = new NoteRepository();
            var notemodel = new Notemodel();
            notemodel.NoteID = 1245;
            
         Assert.IsNotNull(noterepository.GetNote(1245));
        }
    }
}

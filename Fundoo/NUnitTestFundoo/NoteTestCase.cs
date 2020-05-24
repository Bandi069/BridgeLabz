
using Model.NoteModel;
using NUnit.Framework;
using Repository.Repository;

namespace NUnitTestFundoo
{
    [TestFixture]
    public class NoteTestCase
    {
        /// <summary>
        /// Setups this instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Adds the note.
        /// </summary>
        [Test]
        public void AddNote()
        {
            NoteRepository noteRepository = new NoteRepository();
            Notemodel noteModel = new Notemodel()
            {
                NoteID = 123,
                Email = "bandivenu89@gmail.com",
                Title = "title",
                Description = "descrip",
                Archive = true,
                AddImg = "NewImage",
                AddColor = "Red",
                Reminder = "remaindeme",
                Trash = true,
                PinNote = true,
            };
            Assert.IsNotNull(noteRepository.AddNote(noteModel));
        }
        /// <summary>
        /// Deletenotes this instance.
        /// </summary>
        [Test]
        public void Deletenote()
        {
            NoteRepository noterepository = new NoteRepository();
            var notemodel = new Notemodel();
            notemodel.NoteID = 1245;
            Assert.IsNotNull(noterepository.DeleteNote(1245));
        }
        /// <summary>
        /// Updatenotes this instance.
        /// </summary>
        [Test]
        public void Updatenote()
        {
            NoteRepository noterepository = new NoteRepository();
            Notemodel notemodel = new Notemodel()
            {
                NoteID = 1245,
                Email = "bandivenu89@gmail.com",
                Title = "title",
                Description = "descrip",
                Archive = true,
                AddImg = "NewImage",
                AddColor = "Red",
                Reminder = "remaindeme",
                Trash = true,
                PinNote = true,
            };
            Assert.IsNotNull(noterepository.UpdateNote(notemodel));
        }
        /// <summary>
        /// Getnotes this instance.
        /// </summary>
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

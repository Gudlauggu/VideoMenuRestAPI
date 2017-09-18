
using VideoMenuBLL.BusinessObjects;
using VideoMenuDAL.Entities;

namespace VideoMenuBLL.Converters
{
    class VideoConverter
    {
        internal Video Convert(VideoBO vid)
        {
            if (vid == null) { return null; }
            return new Video()
            {
                Id = vid.Id,
                Name = vid.Name,
                GenreId = vid.GenreId
            };
        }

        internal VideoBO Convert(Video vid)
        {
            if (vid == null) { return null; }
            return new VideoBO()
            {
                Id = vid.Id,
                Name = vid.Name,
                Genre = new GenreConverter().Convert(vid.Genre),
                GenreId = vid.GenreId

            };
        }
    }
}

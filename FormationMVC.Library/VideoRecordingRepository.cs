using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationMVC.Library
{
    public class VideoRecordingRepository : AbstractRepository<VideoRecording>
    {

        public IEnumerable<VideoRecording> GetByTitle(string word)
        {
            return GetByLambda(v => v.Title.ToUpper().Contains(word.Trim().ToUpper()));
        }



        public int Count()
        {
            throw new NotImplementedException();
        }
    }
}

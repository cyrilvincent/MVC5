using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationMVC.Library
{
    public class MainService : IMainService
    {
        public VideoRecordingRepository VideoRecordingRepository { get; set; }

        public IEnumerable<VideoCategory> GetAllVideoCategory()
        {
            throw new NotImplementedException();
        }

        public VideoCategory GetVideoCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VideoRecording> GetVideoRecordingsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public VideoRecording GetVideoRecordingById(int id)
        {
            return VideoRecordingRepository.GetById(id);
        }

        public IBasket Basket { get; set; }
        public IBasket AddProductToBasketByProductId(int id)
        {
            VideoRecording vr = GetVideoRecordingById(id);
            Basket.Add(vr);
            return Basket;
        }

        public IBasket RemoveProductFromBasketByProductId(int id)
        {
            VideoRecording vr = GetVideoRecordingById(id);
            Basket.Remove(vr);
            return Basket;
        }


        public void CreateVideoRecording(VideoRecording vr)
        {
            VideoRecordingRepository.Create(vr);
            VideoRecordingRepository.Save();
        }
    }
}

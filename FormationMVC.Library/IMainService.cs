using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationMVC.Library
{
    public interface IMainService
    {
        VideoRecordingRepository VideoRecordingRepository { get; set; }
        IEnumerable<VideoCategory> GetAllVideoCategory();
        VideoCategory GetVideoCategoryById(int id);
        IEnumerable<VideoRecording> GetVideoRecordingsByCategory(int categoryId);
        VideoRecording GetVideoRecordingById(int id);

        IBasket Basket { get; set; }
        IBasket AddProductToBasketByProductId(int id);

        IBasket RemoveProductFromBasketByProductId(int id);



        void CreateVideoRecording(VideoRecording vr);
    }
}

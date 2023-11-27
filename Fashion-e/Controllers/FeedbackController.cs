using Fashion_e.Base;
using Fashion_e.BL.DTOs.Feedback;
using Fashion_e.BL.Services.FeedbackService;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class FeedbackController : BaseController<Feedback, FeedbackDTO>
    {
        public FeedbackController(IFeedbackService feedbackService) : base(feedbackService)
        {
            
        }
    }
}

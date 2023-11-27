using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Feedback;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.FeedbackService
{
    public class FeedbackService : BaseService<Feedback, FeedbackDTO>, IFeedbackService
    {
        public FeedbackService(
            IFeedbackRepository feedbackRepository,
            IMapper mapper
        ) : base( feedbackRepository, mapper )
        {
            
        }
    }
}

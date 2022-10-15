using Newtonsoft.Json;

namespace AdaptiveLearning.Models
{
    /// <summary>
    /// Learning Class
    /// </summary>
    public class Learning
    {
        /// <summary>
        /// Properties
        /// </summary>
        #region Learning Properties

        public string SubmittedAnswerId { get; set; }

        public string SubmitDateTime { get; set; }

        public string Correct { get; set; }

        public string Progress { get; set; }

        public string UserId { get; set; }

        public string ExerciseId { get; set; }

        public string Difficulty { get; set; }

        public string Subject { get; set; }

        public string Domain { get; set; }

        public string LearningObjective { get; set; }
        #endregion
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
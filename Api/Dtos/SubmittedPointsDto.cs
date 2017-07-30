namespace HqyBiggestLoserApi.Api.Dtos
{
    public class SubmittedPointsDto
    {
        public decimal? Weight { get; set; }
        public bool weighIn { get; set; }
        public bool WeeklyChallengeCompleted { get; set; }
        public bool LunchLearnAttended { get; set; }
        public bool PlusOne { get; set; }
        public int VeggiesEaten { get; set; }
        public int ExerciseHours { get; set; }
        public bool PersonalGoal { get; set; }
        public bool SupporterInitials { get; set; }
        public bool PostPersonalGoal { get; set; }
        public bool PostOnMotivationThread { get; set; }
    }
}

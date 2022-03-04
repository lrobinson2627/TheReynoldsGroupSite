namespace TheReynoldsGroupSite.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string AskQuestion { get; set; }
        public int QuestionNumber { get; set; }
        public int CategoryType { get; set; }
        public string AssessmentName { get; set; }
        public int? MostLikely { get; set; }
        public int? Likley { get; set; }
        public int? Neutral { get; set; }
        public int? Unlikely { get; set; }
        public int? MostUnlikely { get; set; }

    }
}

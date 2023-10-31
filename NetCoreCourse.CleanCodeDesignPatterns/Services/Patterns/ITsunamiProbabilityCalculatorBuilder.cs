namespace NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns
{
    public interface ITsunamiProbabilityCalculatorBuilder
    {
        TsunamiProbabilityCalculatorBuilder SetHistoricalEvents(int historicalEvents);
        TsunamiProbabilityCalculatorBuilder SetSeismicActivity(double seismicActivity);
        TsunamiProbabilityCalculatorBuilder SetOceanographicData(double oceanographicData);
        double Build();
    }

    public class TsunamiProbabilityCalculatorBuilder : ITsunamiProbabilityCalculatorBuilder
    {
        private int historicalEvents;
        private double seismicActivity;
        private double oceanographicData;

        public TsunamiProbabilityCalculatorBuilder SetHistoricalEvents(int historicalEvents)
        {
            this.historicalEvents = historicalEvents;
            return this;
        }

        public TsunamiProbabilityCalculatorBuilder SetSeismicActivity(double seismicActivity)
        {
            this.seismicActivity = seismicActivity;
            return this;
        }

        public TsunamiProbabilityCalculatorBuilder SetOceanographicData(double oceanographicData)
        {
            this.oceanographicData = oceanographicData;
            return this;
        }

        public double Build()
        {
            if (historicalEvents < 0 || seismicActivity < 0 || oceanographicData < 0)
            {
                throw new InvalidOperationException("Invalid input data for probability calculation.");
            }

            double probability = historicalEvents * 0.3 + seismicActivity * 0.4 + oceanographicData * 0.3;
            return probability;
        }
    }
}

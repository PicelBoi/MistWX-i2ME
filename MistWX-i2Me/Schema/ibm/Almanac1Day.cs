namespace MistWX_i2Me.Schema.ibm;

public class Almanac1DayResponse
{
    public string almanacInterval { get; set; }
    public string almanacRecordDate { get; set; }
    public int almanacRecordPeriod { get; set; }
    public int almanacRecordYearMax { get; set; }
    public int almanacRecordYearMin { get; set; }
    public double precipitationAverage { get; set; }
    public double snowAccumulationAverage { get; set; }
    public string stationId { get; set; }
    public string stationName { get; set; }
    public int temperatureAverageMax { get; set; }
    public int temperatureAverageMin { get; set; }
    public int temperatureAverageMean { get; set; }
    public int temperatureRecordMax { get; set; }
    public int temperatureRecordMin { get; set; }
}
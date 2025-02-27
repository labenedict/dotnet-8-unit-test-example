namespace tourism_recommendation_service.tests;

[TestClass]
public class TourismRecommendationServiceTests
{

	private readonly TourismRecommendationService _tourismRecommendationService;

	public TourismRecommendationServiceTests()
	{
		_tourismRecommendationService = new TourismRecommendationService();
	}

    [TestMethod]
    public void GetTopRecommendation_InputIsAnahiem_ReturnDisneyland()
    {
	    string result = _tourismRecommendationService.GetTopRecommendation("Anahiem");
	    Assert.AreEqual(result,"Disneyland","Recommendation should be Disneyland.");
    }

    [TestMethod]
    public void GetTopRecommendation_InputUnknownCity_ReturnError()
    {
	    string result = _tourismRecommendationService.GetTopRecommendation("Provincetown");
	    Assert.AreEqual(result,"<<City Unknown>>","<<City Unknown>> should be returned.");
    }
}

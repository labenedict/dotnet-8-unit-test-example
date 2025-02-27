namespace tourism_recommendation_service;

public class TourismRecommendationService
{
  public string GetTopRecommendation(string city)
  {
	  string recommendation = string.Empty;

	  switch(city)
	  {
	    case "Anahiem":
	      recommendation = "Disneyland";
              break;
	    case "Atlanta":
	      recommendation = "Coca-Cola Museum";
	      break;
	    case "Buffalo":
	      recommendation = "Anchor Bar";
	      break;
	    case "Camarillo":
	      recommendation = "Flight Line Cafe";
	      break;
	    case "Denver":
	      recommendation = "Red Rocks";
	      break;
	    case "Erie":
	      recommendation = "Presque Isle State Park";
	      break;
	    case "Forksville":
	      recommendation = "Forksville General Store";
	      break;
	    case "Gatlinburg":
	      recommendation = "Anakeesta";
	      break;
	    case "Hollywood":
	      recommendation = "Whiskey a Go-Go";
	      break;
	    case "Indianapolis":
	      recommendation = "Indianapolis Motor Speedway";
	      break;
	    case "Jacksonville":
	      recommendation = "Gary Rossington Grave Site";
	      break;
	    case "Kansas City":
	      recommendation = "Arrowhead Stadium";
	      break;
	    case "Lexington":
	      recommendation = "University of Kentucky";
	      break;
	    case "Miami":
	      recommendation = "South Beach";
	      break;
	    case "New Orleans":
	      recommendation = "Bourbon Street";
	      break;
	    case "Oxnard":
	      recommendation = "The Collection";
	      break;
	    case "Pittsburgh":
	      recommendation = "Duquesne Incline";
	      break;
	    case "Quakertown":
	      recommendation = "Moyer Chicken Farm";
	      break;
	    case "Ridley Park":
	      recommendation = "Boeing";
	      break;
	    case "South Philadelphia":
	      recommendation = "Lincoln Financial Field";
	      break;
	    case "Timonium":
	      recommendation = "Maryland State Fairgrounds";
	      break;
	    case "Uncasville":
	      recommendation = "Mohegan Sun Casino";
	      break;
	    case "Vernon":
	      recommendation = "Hidden Valley Ski Resort";
	      break;
	    case "Williamsburg":
	      recommendation = "Colonial Williamsburg";
	      break;
	    case "Yorba Linda":
	      recommendation = "Ronald Reagan Presidential Library";
	      break;
	    case "Zanesville":
	      recommendation = "Zanesville Museum of Art";
	      break;
	    default:
	      recommendation = "<<City Unknown>>";
	      break;
	  }
	  return recommendation;
  }
}

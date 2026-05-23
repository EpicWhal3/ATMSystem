namespace Presentation.Scenarios;

public interface IScenarioProvider
{
    public IEnumerable<IScenario> GetScenarios();
}
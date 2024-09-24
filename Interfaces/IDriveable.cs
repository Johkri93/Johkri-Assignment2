namespace Interfaces
{
    // IDriveable definierar grundläggande körbara funktioner för ett fordon
    public interface IDriveable
    {
        // Startar fordonets motor
        void StartEngine();

        // Stoppar fordonets motor
        void StopEngine();

        // Returnerar om motorn är igång
        bool IsEngineOn();
    }
}

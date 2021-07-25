using UnityEngine;

public interface IWeatherSensor
{
    int Detect();
}
public abstract class WeatherSensor : ScriptableObject, IWeatherSensor
{
    public abstract int Detect();
}

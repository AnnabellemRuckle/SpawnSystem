using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public SpawnManager spawnManager;
    public TextMeshProUGUI timeText;

    private void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }

    public void OnDayButtonClicked()
    {
        SpawnObjectsDuringDay();
    }

    public void OnNightButtonClicked()
    {
        SpawnObjectsDuringNight();
    }

    private void SpawnObjectsDuringDay()
    {
        // Implement logic to spawn daytime objects
        bool isDay = true; // For simplicity, assume it's daytime.
        spawnManager.SpawnBasedOnTimeOfDay(isDay);
        timeText.text = "It's Day";
    }

    private void SpawnObjectsDuringNight()
    {
        // Implement logic to spawn nighttime objects
        bool isDay = false; // For simplicity, assume it's nighttime.
        spawnManager.SpawnBasedOnTimeOfDay(isDay);
        timeText.text = "It's Night";
    }
}

using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Encapsulation
    [SerializeField] private int _currentScore = 0;

    // Singleton pattern untuk akses global
    public static ScoreManager Instance { get; private set; }

    private void Awake()
    {
        // Singleton: Pastikan hanya ada satu instance

        if(Instance == null)
        {
            Instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    // method untuk menambah score
    public void AddScore(int value)
    {
        _currentScore += value;
        Debug.Log($"Score: {_currentScore}");
        UpdateUI();
    }

    // mendapatkan skor saat ini (read-only)
    public int GetCurrentScore()
    {
        return _currentScore;
    }

    // reset skor ke 0 (untuk restart game)
    public void ResetScore()
    {
        _currentScore = 0;
    }

    private void Start()
    {
        //2. Initialize UI dengan skor awal (0)
        UpdateUI();
    }


    private void UpdateUI() //1. Buat Function UpdateUI
    {
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateScoreDisplay(_currentScore);
        }
    }

}
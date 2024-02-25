using System;
using UnityEngine;
using UnityEngine.UI;

public class RestartPanel : MonoBehaviour
{
    [SerializeField] private GameObject _restartPanel;
    [SerializeField] private Button _restartButton;

    private CharacterData _characterData;

    public event Action<CharacterData> RestartScene;

    public void Init(CharacterData characterData)
    {
        _characterData = characterData;
        Hide();
        _restartButton.onClick.AddListener(Restart);
    }

    private void OnDestroy()
    {
        _restartButton.onClick.RemoveListener(Restart);
    }

    public void Restart()
    {
        RestartScene?.Invoke(_characterData);
        Hide();
    }

    public void Show()
    {
        _restartPanel.SetActive(true);
    }

    public void Hide()
    {
        _restartPanel.SetActive(false);
    }
}

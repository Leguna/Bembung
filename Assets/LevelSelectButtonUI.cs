using Base;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class LevelSelectButtonUI : MonoBehaviour
{
    [SerializeField] private TMP_Text levelUIText;
    [SerializeField] private Image bg;
    [SerializeField] private Image frontBg;
    [SerializeField] private GameMode gameMode = GameMode.Standard;
    [SerializeField] private int level;
    [SerializeField] private UnityAction<string> _onClick;

    public bool isLocked = true;
    [SerializeField] private Button button;
    private AudioSource _audioSource;

    public void UnlockLevel()
    {
        PlayUnlockAnimation();
        UnlockingLevelUI();
    }

    private void UnlockingLevelUI()
    {
        isLocked = false;
        levelUIText.text = $"{level}";
        levelUIText.fontSize = 24f;
        frontBg.enabled = false;
        button.enabled = true;
        button.onClick.AddListener(() => { _onClick.Invoke($"{gameMode}_{level}"); });
    }

    private void PlayUnlockAnimation()
    {
        _audioSource.Play();
    }

    [CustomEditor(typeof(LevelSelectButtonUI))]
    class LevelSelectButtonUIEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            var levelSelectButtonUI = (LevelSelectButtonUI)target;

            if (GUILayout.Button("Unlock Level"))
                levelSelectButtonUI.UnlockLevel();
        }
    }
}
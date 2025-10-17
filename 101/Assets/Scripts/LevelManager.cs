using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
  [SerializeField] private GameObject settingsPanel;
  void Start()
  {
    settingsPanel.SetActive(false);
  }

  void Update()
  {
    OpenSettings();
  }

  void OpenSettings()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      settingsPanel.SetActive(true);
    }
  }
}

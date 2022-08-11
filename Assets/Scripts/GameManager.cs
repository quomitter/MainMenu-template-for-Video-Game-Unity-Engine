using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;
    public void Start(){
        Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        for(int i = 0; i < resolutions.Length; i++){
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height){
                currentResolutionIndex = i;
            }
        }   
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void PlayGame(){
        SceneManager.LoadScene(0);
    }
    public void GameOptions(){
        SceneManager.LoadScene(0);
    }
    public void GameQuit(){
        Application.Quit();
    }
    public void SetVolume(float volume){
        audioMixer.SetFloat("Volume", volume);
    }
    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullscreen(bool isFullscreen){
        Screen.fullscreen = isFullscreen;
    }
    
}

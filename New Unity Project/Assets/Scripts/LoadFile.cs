using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using SimpleFileBrowser;
using TMPro;
using Dummiesman;

public class LoadFile : MonoBehaviour
{
	[SerializeField] public TMP_Text title;
	[SerializeField] public GameObject standardmodel;
	private string destinationPath;
	private Mesh mesh;
    GameObject loadedObject;
	public Component[] children;
    string error = string.Empty;

	public void Import()
	{
		FileBrowser.SetFilters(true, new FileBrowser.Filter("Objects",".obj"));

		FileBrowser.SetDefaultFilter(".obj");

		FileBrowser.SetExcludedExtensions(".lnk", ".tmp", ".zip", ".rar", ".exe");

		FileBrowser.AddQuickLink("Users", "C:\\Users", null);

		StartCoroutine(ShowLoadDialogCoroutine());
	}

	IEnumerator ShowLoadDialogCoroutine()
	{
		yield return FileBrowser.WaitForLoadDialog(FileBrowser.PickMode.Files, false, null, null, "Load Objec", "Load");

		if(FileBrowser.Success)
		{
			byte[] bytes = FileBrowserHelpers.ReadBytesFromFile(FileBrowser.Result[0]);

			destinationPath = Path.Combine(Application.persistentDataPath, FileBrowserHelpers.GetFilename(FileBrowser.Result[0]));
			FileBrowserHelpers.CopyFile(FileBrowser.Result[0], destinationPath);

			title.text = destinationPath;

			
		}
	}

	public void UseModel()
	{
        if (!File.Exists(destinationPath))
        {
            error = "File doesn't exist.";
        }
		else
		{
            if(loadedObject != null){
                Destroy(loadedObject);
			}
            loadedObject = new OBJLoader().Load(destinationPath);
            error = string.Empty;
        }
        if (error != "")
		{
			Debug.Log(error);
		}
		loadedObject.AddComponent<MeshFilter>();
		loadedObject.AddComponent<MeshRenderer>();
		loadedObject.AddComponent<LoadFile>();

		foreach(Transform child in loadedObject.transform)
		{
			child.gameObject.AddComponent<MeshCollider>();
			child.gameObject.AddComponent<ChangeColorofObject>();
		}
	
		loadedObject.transform.position = new Vector3(24.26881f,0.02f,-314.96f);
		loadedObject.transform.localScale = new Vector3(1.5f,1.5f,1.5f);

		Destroy(standardmodel);
		title.text = "Done";
	}
}
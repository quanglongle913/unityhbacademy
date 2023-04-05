using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class readFile : MonoBehaviour
{
    public Button yourButton;
    private lopHoc lopU22_2;

    // Start is called before the first frame update
    void Start()
    {
        lopU22_2 = new lopHoc();
        lopU22_2.teachers = new List<giangVien>();
        lopU22_2.students = new List<sinhVien>();

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        ReadString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadString()
    {
        string path = "Assets/Resources/lopU22_2.dat";
        //Read the text from directly from the test.txt file
        //StreamReader reader = new StreamReader(path);
        //Debug.Log(reader.ReadToEnd());
        //reader.Close();
        BinaryFormatter formatter = new BinaryFormatter();
        if (File.Exists(path))
        {
            FileStream dataStream = new FileStream(path, FileMode.Open);
            //formatter.Serialize(dataStream, lopU22_2);
            lopU22_2 = (lopHoc)formatter.Deserialize(dataStream);
            dataStream.Close();
            //Debug.Log(lopU22_2.students[0].sex + " aaa");

        }
        /*if (lopU22_2.students[0]!=null) {
            //Debug.Log(lopU22_2.students[0].sex + " aaa");

        }else
            Debug.Log("null");*/

    }
}

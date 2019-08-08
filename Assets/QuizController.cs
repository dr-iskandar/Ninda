using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizController : MonoBehaviour
{
    public GameObject[] allQuiz;
    public GameObject resultContainer;
    public Animator anim; 
    public TMP_Text resultPoint;
    public AudioSource benar, salah;
    public int Point;
    public int QCount = 0;
    public int[] Nilai;


    private void Update()
    {
        resultPoint.text = Point.ToString();
    }

    public void Home()
    {
        Point = 0;
        QCount = 0;
        resultPoint.text = "";
        anim.SetTrigger("out");
        for (int i = 0; i < allQuiz.Length; i++)
        {
            allQuiz[i].SetActive(false);
        }
    }

    public void JawabanBenar(int soal)
    {
        benar.Play();
        Point += Nilai[soal];
        QCount++;
        if (QCount > 19)
        {
            anim.SetTrigger("in");
        }
    }

    public void JawabanSalah()
    {
        salah.Play();
        QCount++;

        if (QCount > 19)
        {
            anim.SetTrigger("in");
        }

    }

    IEnumerator PointCounter(int nilai)
    {
        yield return new WaitForSeconds(1);
        anim.GetComponent<Text>().text = nilai.ToString();
        anim.SetTrigger("in");
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;


namespace ScorePublic
{

    public class Score : MonoBehaviour
    {
        public static float CV = 0; //variavel para conter os numeros (em float) do score
        public Text Text_Score_Dados;  //variavel string que ira enjetar o conteudo no campo texto no pracar do jogo
        public static float AddCV;  //variavel para incrementação do FallTime

        [Serializable] //mostra o conteudo no Inspector
        public struct ScoreBlocks
        {
            public float linhapreEnchida;
            public float blocoNalinha;
            public float blocospreEnchidos;
            public float scoreData;


            public ScoreBlocks(float A, float B, float C, float D)
            {
                this.linhapreEnchida = A;
                this.blocoNalinha = B;
                this.blocospreEnchidos = C;
                this.scoreData = D;


            }
        }


        /*switch(float AddCV)
            {
            case 1:
            float CV =< 50;
            f

            }*/

        [SerializeField]
        ScoreBlocks BlocksCondition;

        //modulo sem uso por enquanto
        public void Modulo()
        {
            ScoreBlocks vetor =  new  ScoreBlocks(15, 30, 1, 0);
        }



            void Start()
        {
            //Text_Score_Dados = GetComponent<Text>();
            //Score.CV = 0;
        }

        // Update is called once per frame
        void Update()
        {
            //Text_Score_Dados.text = "Acore:  " + CV;
            Text_Score_Dados.text = CV.ToString(); // atribuindo o valo de CV a variavel Text_Score_Dados, e convertendo o conteudo para string
           
        }

    }
}

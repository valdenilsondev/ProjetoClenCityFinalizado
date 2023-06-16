using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class inputField : MonoBehaviour
{
   
    public TMP_InputField[] _inputField;
    public int identificadorId;
    public string palavraCompleta;
    public bool isVerificar;
    public List<int> idAtual;
    public List<string> nomeCompleto;
    public string letra;


    public GameObject painelPalavraCruzada;
    public GameObject painelInstrucoes;
    public GameObject painelGameOver;
    public GameObject painelCongratulation;
    public GameObject painelTelaInicialPalavrasCruzadas;
    

    private void Update()
    {
        letra = _inputField[identificadorId].text;
    }

    public void inserir(string letra)
    {
       _inputField[identificadorId].text = letra;

       
    }

    public void identificador(int id)
    {
        identificadorId = id;
    }

    public void Checar()
    {


        if (_inputField[26].text == "R")
        {
         
            _inputField[26].text = "R";
            _inputField[26].image.color = Color.green;
            

        }else if (_inputField[26].text != "R")
        {
           // _inputField[26].text = "R";
            _inputField[26].image.color = Color.red;
        }

        if (_inputField[0].text == "G")
        {
            _inputField[0].image.color  = Color.green;
            _inputField[0].text = "G";
        }
        else if (_inputField[0].text != "G")
        {
           // _inputField[0].text = " ";
            _inputField[0].image.color = Color.red;
        }

        if (_inputField[1].text == "A")
        {
            _inputField[1].image.color = Color.green;
            _inputField[1].text = "A";

        }
        else if (_inputField[1].text != "A")
        {
          //  _inputField[1].text = " ";
            _inputField[1].image.color = Color.red;
        }

        if (_inputField[2].text == "S")
        {
            _inputField[2].text = "S";
            _inputField[2].image.color = Color.green;
     

        }
        else if (_inputField[2].text != "S")
        {
           // _inputField[2].text = " ";
            _inputField[2].image.color = Color.red;
        }

        if (_inputField[3].text == "M")
        {
            _inputField[3].image.color = Color.green;
            _inputField[3].text = "M";

        }
        else if (_inputField[3].text != "M")
        {
           // _inputField[3].text = " ";
            _inputField[3].image.color = Color.red;
        }

        if (_inputField[4].text == "E")
        {
            _inputField[4].image.color = Color.green;
            _inputField[4].text = "E";

        }
        else if (_inputField[4].text != "E")
        {
           // _inputField[4].text = " ";
            _inputField[4].image.color = Color.red;
        }


        if (_inputField[5].text == "T")
        {
            _inputField[5].image.color = Color.green;
            _inputField[5].text = "T";

        }
        else if (_inputField[5].text != "T")
        {
           // _inputField[5].text = " ";
            _inputField[5].image.color = Color.red;
        }


        if (_inputField[6].text == "A")
        {
            _inputField[6].image.color = Color.green;
            _inputField[6].text = "A";

        }
        else if (_inputField[6].text != "A")
        {
         //   _inputField[6].text = " ";
            _inputField[6].image.color = Color.red;
        }

        if (_inputField[7].text == "N")
        {
            _inputField[7].image.color = Color.green;
            _inputField[7].text = "N";

        }
        else if (_inputField[7].text != "N")
        {
         //   _inputField[7].text = " ";
            _inputField[7].image.color = Color.red;
        }

        if (_inputField[8].text == "O")
        {
            _inputField[8].image.color = Color.green;
            _inputField[8].text = "O";

        }
        else if (_inputField[8].text != "O")
        {
           // _inputField[8].text = " ";
            _inputField[8].image.color = Color.red;
        }



        if (_inputField[22].text == "L")
        {
            _inputField[22].image.color = Color.green;
            _inputField[22].text = "L";

        }
        else if (_inputField[22].text != "L")
        {
          //  _inputField[22].text = " ";
            _inputField[22].image.color = Color.red;
        }


        if (_inputField[21].text == "U")
        {
            _inputField[21].image.color = Color.green;
            _inputField[21].text = "U";

        }
        else if (_inputField[21].text != "U")
        {
           // _inputField[21].text = " ";
            _inputField[21].image.color = Color.red;
       }


        if (_inputField[20].text == "Z")
        {
            _inputField[20].image.color = Color.green;
            _inputField[20].text = "Z";

        }
        else if (_inputField[20].text != "Z")
        {
          //  _inputField[20].text = " ";
            _inputField[20].image.color = Color.red;
        }

        if (_inputField[2].text == "S")
        {
            _inputField[2].image.color = Color.green;
            _inputField[2].text = "S";

        }
        else if (_inputField[2].text != "S")
        {
           // _inputField[2].text = " ";
            _inputField[2].image.color = Color.red;
        }

        if (_inputField[23].text == "O")
        {
            _inputField[23].image.color = Color.green;
            _inputField[23].text = "O";

        }
        else if (_inputField[23].text != "O")
        {
          //  _inputField[23].text = " ";
            _inputField[23].image.color = Color.red;
        }


        if (_inputField[24].text == "L")
        {
            _inputField[24].image.color = Color.green;
            _inputField[24].text = "L";

        }
        else if (_inputField[24].text != "L")
        {
          //  _inputField[24].text = " ";
            _inputField[24].image.color = Color.red;
        }

        if (_inputField[25].text == "A")
        {
            _inputField[25].image.color = Color.green;
            _inputField[25].text = "A";

        }
        else if (_inputField[25].text != "A")
        {
           // _inputField[25].text = " ";
            _inputField[25].image.color = Color.red;
        }

       

        if (_inputField[18].text == "I")
        {
            _inputField[18].image.color = Color.green;
            _inputField[18].text = "I";

        }
        else if (_inputField[18].text != "I")
        {
           // _inputField[18].text = " ";
            _inputField[18].image.color = Color.red;
        }



        if (_inputField[17].text == "N")
        {
            _inputField[17].image.color = Color.green;
            _inputField[17].text = "N";

        }
        else if (_inputField[17].text != "N")
        {
            // _inputField[18].text = " ";
            _inputField[17].image.color = Color.red;
        }


        if (_inputField[16].text == "S")
        {
            _inputField[16].image.color = Color.green;
            _inputField[16].text = "S";

        }
        else if (_inputField[16].text != "S")
        {
            // _inputField[18].text = " ";
            _inputField[16].image.color = Color.red;
        }


        if (_inputField[15].text == "E")
        {
            _inputField[15].image.color = Color.green;
            _inputField[15].text = "E";

        }
        else if (_inputField[15].text != "E")
        {
            // _inputField[18].text = " ";
            _inputField[15].image.color = Color.red;
        }

        if (_inputField[14].text == "T")
        {
            _inputField[14].image.color = Color.green;
            _inputField[14].text = "T";

        }
        else if (_inputField[14].text != "T")
        {
            // _inputField[18].text = " ";
            _inputField[14].image.color = Color.red;
        }

        if (_inputField[13].text == "O")
        {
            _inputField[13].image.color = Color.green;
            _inputField[13].text = "O";

        }
        else if (_inputField[13].text != "O")
        {
            // _inputField[18].text = " ";
            _inputField[13].image.color = Color.red;
        }


        if (_inputField[12].text == "S")
        {
            _inputField[12].image.color = Color.green;
            _inputField[12].text = "S";

        }
        else if (_inputField[12].text != "S")
        {
            // _inputField[18].text = " ";
            _inputField[12].image.color = Color.red;
        }

        if (_inputField[11].text == "E")
        {
            _inputField[11].image.color = Color.green;
            _inputField[11].text = "E";

        }
        else if (_inputField[11].text != "E")
        {
            // _inputField[18].text = " ";
            _inputField[11].image.color = Color.red;
        }

        if (_inputField[10].text == "R")
        {
            _inputField[10].image.color = Color.green;
            _inputField[10].text = "R";

        }
        else if (_inputField[10].text != "R")
        {
            // _inputField[18].text = " ";
            _inputField[10].image.color = Color.red;
        }

        if (_inputField[9].text == "A")
        {
            _inputField[9].image.color = Color.green;
            _inputField[9].text = "A";

        }
        else if (_inputField[9].text != "A")
        {
            // _inputField[18].text = " ";
            _inputField[9].image.color = Color.red;
        }

        if (_inputField[19].text == "O")
        {
            _inputField[19].image.color = Color.green;
            _inputField[19].text = "O";

        }
        else if (_inputField[19].text != "O")
        {
            // _inputField[18].text = " ";
            _inputField[19].image.color = Color.red;
        }


    }

    public void FecharPainelCacaPalavras()
    {
        painelPalavraCruzada.SetActive(false);
    }

    public void FecharPainelGameOver()
    {
        painelGameOver.SetActive(false);
    }

    public void FecharPainelInstrucoes()
    {
        painelInstrucoes.SetActive(false);
    }

    public void FecharPainelCongratulation()
    {
        painelCongratulation.SetActive(false);
    }

    public void FecharPainelTelaInicialPalavrasCruzadas()
    {
        painelTelaInicialPalavrasCruzadas.SetActive(false);
    }

    public void AbrirInstrucoes()
    {
        painelInstrucoes.SetActive(true);
    }

 }

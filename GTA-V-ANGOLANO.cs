using UnityEngine;

public class LuandaMapGenerator : MonoBehaviour
{
    [Header("Configurações do Mapa")]
    public int quantidadeLinhas = 5;
    public int quantidadeColunas = 5;
    public float espacamentoBloco = 20f;

    [Header("Modelos (Prefabs)")]
    public GameObject prefabEdificio;
    public GameObject prefabAsfalto;

    void Start()
    {
        GerarCidade();
    }

    void GerarCidade()
    {
        for (int x = 0; x < cantidadLinhas; x++)
        {
            for (int z = 0; z < quantidadeColunas; z++)
            {
                // Calcula a posição de cada bloco da cidade
                Vector3 posicaoBloco = new Vector3(x * espacamentoBloco, 0, z * espacamentoBloco);

                // Cria o chão/rua
                if (prefabAsfalto != null)
                {
                    Instantiate(prefabAsfalto, posicaoBloco, Quaternion.identity, transform);
                }

                // Cria o edifício em cima do bloco
                if (prefabEdificio != null)
                {
                    Vector3 posicaoEdificio = posicaoBloco + new Vector3(0, 0.5f, 0);
                    GameObject novoEdificio = Instantiate(prefabEdificio, posicaoEdificio, Quaternion.identity, transform);

                    // Altera a altura de forma aleatória para simular prédios diferentes
                    float alturaAleatoria = Random.Range(1f, 5f);
                    novoEdificio.transform.localScale = new Vector3(5, alturaAleatoria * 3, 5);
                }
            }
        }
        Debug.Log("Mapa de Luanda gerado com sucesso!");
    }
}
novoEdificio.transform.localScale

using System;
using System.Collections.Generic;


namespace Program;

class Program
{
    // Criando a lista de fila e pilha
    static Queue<string> tarefasPendentes = new Queue<string>();
    static Stack<string> tarefasConcluidas = new Stack<string>();

    static void Main(string[] args)
    {
        int opcao;

        // Criação do menu interativo
        do
        {
            MostrarMenu();
            int.TryParse(Console.ReadLine(), out opcao);
            Console.Clear();


            switch (opcao)
            {
                case 1:
                    AdicionarTarefa();
                    break;
                case 2:
                    ConcluirTarefa();
                    break;
                case 3:
                    DesfazerConclusao();
                    break;
                case 4:
                    ListarTarefas();
                    break;
                case 0:
                    Console.WriteLine("Programa Encerrado. ");
                    break;
                default:
                    Console.WriteLine("Opção Inválida. ");
                    break;
            }
            if (opcao != 0)
            {
                Console.WriteLine("\n Pressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        } while (opcao != 0);
    }


    static void MostrarMenu()
    {
        Console.WriteLine("xxxxxxxxxx Gerenciador de Tarefas xxxxxxxxxx\n");
        Console.WriteLine("1. Adicionar tarefa");
        Console.WriteLine("2. Concluir tarefa");
        Console.WriteLine("3. Desfazer última conclusão");
        Console.WriteLine("4. Listar tarefas");
        Console.WriteLine("0. Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void AdicionarTarefa()
    {
        Console.WriteLine("Insira a descrição da tarefa: ");
        string tarefa = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(tarefa))
        {
            tarefasPendentes.Enqueue(tarefa);
            Console.WriteLine("Tarefa adicionada com sucesso !");
        }
        else
        {
            Console.WriteLine("Tarefa inválida.");
        }
    }

    static void ConcluirTarefa()
    {
        if (tarefasPendentes.Count > 0)
        {
            string tarefa = tarefasPendentes.Dequeue();
            tarefasConcluidas.Push(tarefa);
            Console.WriteLine($"Tarefa Concluída: {tarefa}");
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa pendente para concluir.");
        }
    }

    static void DesfazerConclusao()
    {
        if (tarefasConcluidas.Count > 0)
        {
            string tarefa = tarefasConcluidas.Pop();
            tarefasPendentes.Enqueue(tarefa);
            Console.WriteLine($"Desfeita a conclusão da tarefa: {tarefa}");
        }
        else
        {
            Console.WriteLine("Nenhuma tarefa concluída para desfazer.");
        }
    }

    static void ListarTarefas()
    {
        Console.WriteLine("Tarefas Pendentes: ");
        {
            if (tarefasPendentes.Count == 0)
                Console.WriteLine("Nenhuma. ");
            else
            {
                foreach (var tarefa in tarefasPendentes)
                    Console.WriteLine($"-- {tarefa} --");
            }

            Console.WriteLine("Tarefas Concluídas: ");
            if (tarefasConcluidas.Count == 0)
                Console.WriteLine("Nenhuma. ");
            else
            {
                foreach (var tarefa in tarefasConcluidas)
                    Console.WriteLine($"-- {tarefa} --");
            }
        }
    }

}
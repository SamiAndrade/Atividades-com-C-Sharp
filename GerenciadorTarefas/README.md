# 📝 Gerenciador de Tarefas em C#

Este é um projeto simples de terminal feito em **C#** que permite o gerenciamento de tarefas, com funcionalidades para adicionar, concluir, desfazer e listar tarefas. Ele utiliza **Queue** e **Stack** para controlar as tarefas pendentes e concluídas, respectivamente.

## 🚀 Funcionalidades

- ✅ **Adicionar tarefa**  
  Adiciona uma nova tarefa à fila de tarefas pendentes.

- ✔️ **Concluir tarefa**  
  Move a próxima tarefa pendente para a pilha de tarefas concluídas.

- 🔄 **Desfazer última conclusão**  
  Remove a última tarefa concluída da pilha e a retorna para a fila de tarefas pendentes.

- 📋 **Listar tarefas**  
  Exibe todas as tarefas pendentes e concluídas.

- ❌ **Sair do programa**

## 💡 Estrutura de Dados Utilizada

- **Queue (`tarefasPendentes`)**: Para armazenar as tarefas que ainda precisam ser feitas, mantendo a ordem de chegada (FIFO).
- **Stack (`tarefasConcluidas`)**: Para armazenar as tarefas concluídas, possibilitando desfazer a última ação (LIFO).

## 🛠️ Como executar

1. Certifique-se de ter o **.NET SDK** instalado ([Download .NET SDK](https://dotnet.microsoft.com/download)).
2. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/gerenciador-tarefas-csharp.git
   cd gerenciador-tarefas-csharp

3. Para rodar o programa:
```bash
dotnet run
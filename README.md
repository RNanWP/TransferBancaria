# 🏦 Conta Bancária em C#

Um aplicativo simples de simulação de **transferências entre contas bancárias** desenvolvido em C#. Este projeto utiliza a interface Windows Forms para permitir que os usuários realizem depósitos, saques e transferências, com uma apresentação clara e intuitiva.

## 📖 Funcionalidades

- **Criação de Contas:** Simule duas contas bancárias com titulares e números de conta.
- **Depósito de Valores:** Adicione fundos a qualquer uma das contas de forma simples e rápida.
- **Saque de Valores:** Realize saques de uma conta específica, garantindo que haja saldo suficiente.
- **Transferência entre Contas:** Transfira valores entre as contas com feedback instantâneo.
- **Consulta de Saldo:** Exiba o saldo atual de cada conta na interface.
- **Validação de Entrada:** Garantia de que somente valores numéricos e positivos sejam aceitos.
- **Formatação Monetária:** Exiba valores com a formatação correta (R$).

## 💻 Tecnologias Utilizadas

- C#
- Windows Forms
- Visual Studio

## 🛠 Estrutura do Projeto

### Classes Principais
- **ContaBancaria**

    - **Propriedades:**

        - **NumeroConta:** O número da conta bancária.
        - **Titular:** Nome do titular da conta.
        - **Saldo:** O saldo disponível na conta.

**Métodos:**

    - **Depositar(decimal valor):** Adiciona um valor ao saldo da conta.
    - **Sacar(decimal valor):** Retira um valor do saldo, se houver saldo suficiente.
    - **ConsultarSaldo():** Retorna o saldo atual da conta.
    - **Transferir(ContaBancaria contaDestino, decimal valor):** Transfere um valor para outra conta.

-  **Form1**

- Interface do usuário que gerencia as interações e exibe informações.
- Contém botões para executar saques, transferências e exibir saldos.

## 🚀 Como Executar o Projeto

1. Clone o repositório:

```bash
    git clone https://github.com/RNanWP/TransferBancaria.git
```

2. Abra no Visual Studio:
    - Inicie o Visual Studio e carregue o projeto.

3. Compile e Execute:
    - Compile o projeto e execute o aplicativo para começar a usar.

## Estrutura do Projeto

```markdown
├── TransferenciaBancaria
│ ├── Form1.cs             # Código principal do formulário
│ ├── ContaBancaria.cs     # Implementação da classe ContaBancaria
│ ├── Program.cs           # Ponto de entrada do aplicativo
│ └── Form1.Designer.cs    # Designer do formulário
└── README.md              # Documentação do projeto
```

## Licença

Este projeto está licenciado sob a MIT License

## Contato

Para mais informações, entre em contato:

- Nome: Renan Santos de Oliveira.
- Email: renan92011@hotmail.com

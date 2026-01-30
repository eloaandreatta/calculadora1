# Calculadora (C#) — Em evolução 🚀

Uma calculadora simples em **C# (Console)** criada para treinar lógica de programação e fundamentos da linguagem.  
Este projeto está em **desenvolvimento contínuo**: vou fazer melhorias aos poucos até virar uma versão mais avançada.

---

## ✅ Funcionalidades atuais

- Lê dois números inteiros
- Lê uma operação (`+`, `-`, `*`, `/`)
- Calcula e exibe o resultado no formato: `n1 op n2 = resultado`
- Exibe mensagem para operação inválida

---

## 🧠 O que estou treinando com esse projeto

- Entrada e saída no console (`Console.ReadLine`, `Console.WriteLine`)
- Conversão de tipos (`int.Parse`)
- Controle de fluxo (`switch/case`)
- Variáveis e operadores aritméticos

---

🧪 Exemplo de uso
Digite um número:
10
Digite a operação:
+
Digite o segundo número:
5
10 + 5 = 15

⚠️ Limitações atuais

Só aceita números inteiros (ex: 5 / 2 resulta em 2, divisão inteira)

int.Parse pode gerar erro se o usuário digitar letras

Divisão por zero pode quebrar o programa

Não há repetição (o programa encerra após um cálculo)

🛠️ Próximas melhorias (Roadmap)

As melhorias serão feitas por etapas, mantendo o projeto evolutivo:

Etapa 1 — Robustez

 Validar entrada do usuário (usar int.TryParse)

 Tratar divisão por zero

 Melhorar mensagens de erro

Etapa 2 — Melhorias de uso

 Loop para continuar calculando sem reiniciar o programa

 Opção de sair (q ou 0)

 Histórico de cálculos na sessão

Etapa 3 — Operações avançadas

 Trabalhar com números decimais (double)

 Potência, raiz, porcentagem

 Parênteses e precedência (versão mais avançada)

Etapa 4 — Estrutura mais profissional

 Separar lógica em métodos

 Organização em classes (POO)

 Testes unitários (xUnit)

 Logs e tratamento de exceções

📌 Status do projeto

Em desenvolvimento / aprendizado
A ideia é manter commits frequentes mostrando a evolução do código.

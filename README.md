# Monitor de Saúde Digital

Aplicação de console em C# para registrar e acompanhar hábitos de bem-estar usando apenas arrays internos e um menu interativo. Ideal para demonstrar lógica de programação, validação de entrada e exibição de estatísticas sem depender de banco de dados.

---

## 👥 Integrantes

| Nome | RM |
|------|-----|
| Gabriel Mediotti Marques | 552632 |
| Jó Sales | 552679 |
| Miguel Garcez de Carvalho | 553768 |
| Vinicius Souza e Silva | 552781 |

---

## 📋 Sobre o Projeto

Este projeto foi desenvolvido como parte da **Sprint 1** da disciplina de C# na FIAP. O objetivo é criar uma aplicação simples e funcional que permita ao usuário monitorar suas atividades de saúde e bem-estar do dia a dia.

### 🎯 Objetivo

Permitir que o usuário registre e acompanhe diferentes tipos de atividades relacionadas à saúde, como:
- **Exercícios físicos** (em minutos)
- **Consumo de água** (em litros)
- **Horas de sono** (em horas)
- E qualquer outra atividade que desejar monitorar

---

## ✨ Funcionalidades

| Funcionalidade | Descrição |
|----------------|-----------|
| ➕ **Adicionar registro** | Insere uma nova atividade com tipo, data e valor numérico |
| 📋 **Listar registros** | Exibe todos os registros armazenados de forma organizada |
| 📊 **Exibir estatísticas** | Mostra total, média e quantidade de registros por tipo de atividade |
| 🚪 **Sair** | Encerra a aplicação |

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# 12
- **Framework:** .NET 9.0
- **Paradigma:** Programação Estruturada
- **Armazenamento:** Arrays em memória 

---

## 📁 Estrutura do Projeto

```
fiap-3espr-csharp-sprint1/
├── 📄 Program.cs                           # Código fonte principal
├── 📄 fiap-3espr-csharp-sprint1.csproj     # Arquivo de configuração do projeto
├── 📄 fiap-3espr-csharp-sprint1.sln        # Arquivo de solução
├── 📄 README.md                            # Documentação do projeto
```

---

## 🚀 Como Executar

### Pré-requisitos

- [.NET SDK 9.0](https://dotnet.microsoft.com/download/dotnet/9.0) ou superior instalado

### Passos

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/FIAP-BitsNBytes/fiap-3espr-csharp-sprint1.git
   ```

2. **Navegue até o diretório do projeto:**
   ```bash
   cd fiap-3espr-csharp-sprint1
   ```

3. **Execute a aplicação:**
   ```bash
   dotnet run
   ```

4. **Siga o menu interativo** para inserir atividades, listar registros ou consultar estatísticas.

---

## 💻 Exemplo de Uso

```
=== Monitor de Saude Digital ===
1 - Adicionar registro
2 - Listar registros
3 - Exibir estatisticas
4 - Sair
Escolha uma opcao: 1

Tipo da atividade (Exercicio, Agua, Sono...): Exercicio
Data da atividade (dd/MM/yyyy): 27/11/2025
Valor (minutos, litros ou horas): 45
Registro adicionado com sucesso!
```

### Exemplo de Estatísticas

```
Estatisticas por atividade:
Exercicio -> Total: 120 | Media: 40 | Registros: 3
Agua -> Total: 6.5 | Media: 2.17 | Registros: 3
Sono -> Total: 21 | Media: 7 | Registros: 3
```

---

## 📌 Regras de Validação

| Campo | Regra |
|-------|-------|
| **Tipo** | Texto não pode ser vazio ou apenas espaços |
| **Data** | Deve estar no formato `dd/MM/yyyy` |
| **Valor** | Número não negativo (≥ 0) |

---

## ⚠️ Observações Importantes

- 📦 **Armazenamento temporário:** Os dados ficam apenas durante a execução (arrays em memória)
- 🔢 **Limite de registros:** Máximo de 200 registros por sessão
- 🌐 **Cultura:** Utiliza formato brasileiro (pt-BR) para datas e números
- 🔍 **Busca de tipos:** A comparação de tipos é case-insensitive (não diferencia maiúsculas/minúsculas)

---

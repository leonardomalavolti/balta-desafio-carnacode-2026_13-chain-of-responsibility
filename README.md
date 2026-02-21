![CO-1](https://github.com/user-attachments/assets/7b600675-587d-4e1a-9786-2ea50e35d8a7)

## 🥁 CarnaCode 2026 - Desafio 13 - Chain of Responsibility

Oi, eu sou o Leonardo Malavolti e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

---

### 🎯 Sobre este desafio

No desafio **Chain of Responsibility** eu precisei resolver um problema real implementando o **Design Pattern** em questão.

Neste processo eu pratiquei:

* ✅ Boas Práticas de Software  
* ✅ Código Limpo  
* ✅ SOLID  
* ✅ Princípio Open/Closed  
* ✅ Encadeamento de responsabilidades  

---

## 🚨 Problema

Uma empresa precisa processar pedidos de reembolso com diferentes níveis de aprovação baseados no valor.

O sistema original utilizava:

- ❌ Condicionais gigantes (if/else aninhados)
- ❌ Switch case complexo
- ❌ Código duplicado
- ❌ Forte acoplamento
- ❌ Dificuldade para adicionar novos níveis hierárquicos
- ❌ Violação do Single Responsibility

Cada vez que um novo nível de aprovação era adicionado, era necessário modificar toda a estrutura condicional.

---

## 🧠 Solução com Chain of Responsibility

A solução foi aplicar o padrão **Chain of Responsibility**, onde:

- Cada nível de aprovação é um **Handler**
- Cada handler decide se pode aprovar ou deve encaminhar
- A cadeia é configurada dinamicamente
- Não há mais condicionais gigantes

### Estrutura aplicada:

- `IExpenseHandler`
- `ExpenseHandlerBase`
- `SupervisorHandler`
- `ManagerHandler`
- `DirectorHandler`
- `CEOHandler`
- `ExpenseRequest`

---

## 🔄 Funcionamento

1. A requisição entra no primeiro nível (Supervisor)
2. Se estiver dentro do limite, ele aprova
3. Caso contrário, encaminha para o próximo nível
4. O fluxo continua até que alguém aprove
5. Caso nenhum handler aprove, a requisição é rejeitada

Tudo isso sem if/else encadeado e sem switch.

---

## 🚀 Benefícios alcançados

✔ Código aberto para extensão  
✔ Novos níveis podem ser adicionados sem modificar os existentes  
✔ Baixo acoplamento  
✔ Melhor organização  
✔ Melhor testabilidade  
✔ Redução da complexidade cognitiva  
✔ Aplicação prática de SOLID  

---

## 📚 Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais.

Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na identificação de códigos não escaláveis e na solução de problemas utilizando padrões amplamente utilizados no mercado.

---

### 📖 eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito:

👉 https://lp.balta.io/ebook-fundamentos-design-patterns

---

### 🔗 Veja meu progresso no desafio

[Incluir link para o repositório central]

---

🎭 Desafio 13/23 concluído!

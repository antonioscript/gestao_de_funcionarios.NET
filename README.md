# gestao_de_funcionarios.NET
 Sistema criado com o objetvio de cadastras funcionários de forma simples e prática em um banco de dados, otimizando as tarefas de administração de funcionários, no processo de cadastros das principais informações dos colaboradores
 
 # Tecnologias Utilizadas 
 - Linguagem C# 
- Framework .NET 6
- ASP .NET (Modelo MVC)
- Entity Framework
- Bando de Dados SQLite
- 
 # Objetivo do Sistema
O sistema funciona como uma ferramenta de gestão. permitindo adicionar novos funcionários ao banco de dados da empresa. Além de apresentar ao usuário as opções de atualizar, excluir e filtrar os funcionários de acordo com o nome. 
Vantagens da aplicação:

1 - Agilidade: A ferramenta foi criado de forma a ser intuitiva, com informações claras e precisas, com o objetivo de tornar o processo de cadastro de usuários mais ágil;

2 - Segurança: O usuário (que no caso seria o gerente, chefe, ou dono da empresa) adicionaria as informações em seu próprio banco de dados;

3 - Personalização: A ferramenta pode ser personaliza, diferente dos modelos fixos de terceiros.

 # Tela de Registro
 
 ![image](https://user-images.githubusercontent.com/10932478/173902788-79453f5d-d1a4-46ff-a178-657cc60287c0.png)
<br/> Para entrar no sistema, o usuário precisa criar um conta. O processo é bastante simples, inserindo apenas um email e uma senha.
 
 # Tela Inicial
 
 ![image](https://user-images.githubusercontent.com/10932478/173902857-c2d09fec-fe76-406c-abda-dfeccbac3441.png)
 <br/> Após fazer o login, o usuário se depara com essa tela, onde pode clicar no botão 'cadastrar' para começar a usar as funcionalidades do sistema.
 
 # Tela de Cadastro
 
 ![image](https://user-images.githubusercontent.com/10932478/173902910-db4ca13a-2259-4323-ac05-48a60812b527.png)
 ![image](https://user-images.githubusercontent.com/10932478/173902928-f24d6775-6df8-4ed0-93f5-c8721366f2a1.png)
<br/>  Depois de clicar em Cadastrar aparece ao usuário a tela de cadastro de usuários. Nessa tela, o sistema oferece as opções de preencher os campos de Nome . Email, o setor que aquele funcionário faz parte (Administração, Vendas e Estoque), a data em que o funcionário começou a trabalhar na empresa e o salário que ele recebe atualmente. Após isso, ao clicar em 'Criar' os dados daquele funcionário são armazenados no banco de dados.

 
 # Funcionários Cadastrados
 
 ![image](https://user-images.githubusercontent.com/10932478/173903014-ba2ed340-021f-41b9-bab9-7ec596daff66.png)
<br/> Surge então na tela inicial as informações passadas ao banco de dados.

![image](https://user-images.githubusercontent.com/10932478/173903160-6cb5467b-bc62-4888-8a3f-28a6f06027be.png)
<br/> O usuário pode então adicionar inúmeros funcionários.
 
 # Filtro
 
 ![image](https://user-images.githubusercontent.com/10932478/173903269-267c8deb-83a5-4da7-9e48-3ede6ce8ae52.png)
<br/> Em uma situação onde há centenas de funcionários cadastrados, o usuário pode filtrar o nome de um funcionário específico no campo de 'filtrar', onde o sistema retorna de forma simples e rápida as informações daquele usuário.
 
 # Detalhes
 
 ![image](https://user-images.githubusercontent.com/10932478/173903316-fd6a3973-53d3-43bc-8198-f2eccb62ba4e.png)
<br/> Clicando em 'Detalhes' o usuário tem acesso as principais informações daquele funcionário.
 
 # Editar
 
 ![image](https://user-images.githubusercontent.com/10932478/173903337-65bf560b-209a-4923-91b0-f9940ca3d2d0.png)
<br/>  Clicando em 'Editar' o usuário pode modificar as informações do funcionário. Como por exemplo, alterar o salário, o setor que ele trabalha e o seu salário.

 # Excluir
 
 ![image](https://user-images.githubusercontent.com/10932478/173903387-75d5c7f0-4b01-49cf-a939-7819bf338720.png)
<br/>  E por fim, o usuário pode também clicar em 'Excluir' Removendo assim todas as informações daquele funcionário do banco de dados.
 
 # Link do Código
 https://github.com/antonioscript/gestao_de_funcionarios.NET/tree/main/FuncionarioCadastro

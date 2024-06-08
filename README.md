# Celestial-Realm
Anime Tracker 
# Last Project of my Programming Course

# Objetivos:
- Criar Base de Dados (8 Tabelas/ 52 Campos);
- Fazer as ligações a Base de Dados (11 ligações);
- Criar os Formulários do Projeto (8 formulários);
- Criação de Classes (3 classes);
- Ligar a Base de Dados com o Projeto;
- Login/Entrar (Email / Password);
- SignUp/Iniciar Sessão/Registar/Criar Conta (Nome/Email/Password/Ano/Mês/Dia/Género);
- Fazer o Programa funcionar dependendo do utilizador ativo, assim cada utilizador tem a sua própria lista;
- Listar os Animes com a imagem de cada anime;
- Criação do formulário de conexão a base de dados;
- Criação da classe user (utilizadores), animes e conexão (com  a Base de Dados);
- Pesquisa filtrada de Animes por Nome/Género/Temporada;
- Criar a lista de cada categoria (Para ver/A ver/ Vistos/ desistir/ em espera)
- Adicionar e remover anime à lista e a Base de Dados do utilizador ativo;
- Atualizar o anime na Lista e Base de Dados;
- Adicionar animes aos favoritos;
- Mostrar os 2 primeiros animes favoritos do utilizador;
- Contagem de animes (Para ver/A ver/ Vistos/ desistir/ em espera);
- Atualização de Foto de Perfil/Password/Email/Nome;
- Possibilidade de apagar a conta ao clicar em "Log out”;
- Mostrar a data de entrada na aplicação do utilizador ativo;
- Restard do Programa após criar conta para fazer o login.

# Formulários:

### Login:
- A pessoa com conta criada entra na aplicação com sucesso;
- Usa email e password para entrar e tem que estar registada na base de dados;
### Sign Up:
- A pessoa cria uma conta tendo que preencher nome, email, password, data de nascimento e género;
- Automaticamente, se for com sucesso é inserido na base de dados as informações;
- Leva para o form de login e dá um restard no programa para o programa atualizar conforme os dados;
### Principal (Menu)
- Ligação para os 4 formulários restantes;
- Label de saída que fecha o programa;
### Lista Anime 
- Lista geral dos animes fornecidos na aplicação sendo atualmente 25 em uma datagridview;
- Pesquisa de animes filtrada por nome, genero ou temporadas que consta na DataGridView;
- Picture box que mostra imagem dos animes;
### Lista User
- 5 datas grid view (Para ver/A ver/ Vistos/ desistir/ em espera);
- Os animes aparecem na Data Grid View correspondente;
- Mostra o Nome e o Género do anime;
- Picture box que aparece a imagem de perfil do utilizador ativo;
- Label que mostra o nome do utilizador Ativo;
### Perfil
- Contagem de animes (Para ver/A ver/ Vistos/ desistir/ em espera) em Labels e Textbox;
- Mudar a foto de perfil ao clicar na Picture box onde contem a imagem de perfil;
- Mudar o Nome/Password/Email do utilizador Ativo;
- Nome e Imagem dos 2 Animes Favoritos;
- Logout onde Elimina a conta do utilizador ativo e todos os seus dados na Base de Dados;
- Mostra a Data de Entrada do utilizador ativo;
### Alterar
- Ao clicar no anime na Data Grid View aparece as informações do anime selecionado (nome/género/ descrição/número de episódios);
- Combo box que tem já escrito as categorias que dependerá para onde será levado o anime adicionado; 
- botão adiciona que leva o anime para o form da lista user;
- Botão favorita que favorita o anime selecionado e leva para o perfil;
### Conexão
- Faz a conexão do projeto com a Base de Dados;





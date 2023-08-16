using _08_ConexaoBD;

Console.ForegroundColor = ConsoleColor.Red;

//ConexaoSimples conexaoSimples = new ConexaoSimples();
ConexaoFlexivel conexaoFlexivel = new ConexaoFlexivel();
//conexaoFlexivel.executaQuery("SELECT * FROM tarefas;");
//conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE id = 4;");
conexaoFlexivel.executaQuery("SELECT * FROM tarefas WHERE id = 100 OR id = 33;");

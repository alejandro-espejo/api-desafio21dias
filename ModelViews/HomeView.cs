namespace api_desafio21dias.ModelViews
{
    public record HomeView
    {
        public string Informacao => "Bem vindo ao sistema";

        public List<dynamic> Endpoints => new (){
            new { Item = new { Documentacao = "/swagger" } },
            new { Item = new { Path = "/alunos" } },
        };
    }
}
namespace AulaPOO_Heranca.classes
{  //Com : seguido do nome da superclasse utilizamos a herança 
    public class PessoaJuridica : Pessoa
    {
        public string cnpj
        ;

        public string inscricaoEstadual
        ;

        public bool ValidarCNPJ(string documento){
            if(documento != "" ){
                return true;
            }

            return false;
        }
    }
}
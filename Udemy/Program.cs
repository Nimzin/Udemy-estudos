using System;
using System.Collections.Generic;
using Udemy.Fundamentos;
using Udemy.EstrutrasDeControle;
using Udemy.ClassesEMetodos;
using Udemy.Colecoes;
using static Udemy.ClassesEMetodos.CarroOpcional;
using Udemy.OO;
using Udemy.MetodosEFuncoes;
using Udemy.Excecoes;
using Udemy.API;
using Udemy.TopicosAvancados;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferências - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIF.Executar},
                {"Estrutura IF / Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If / Else / If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar},
                {"Estrutura Break - Estruturas de Controle", EstruturaBreak.Executar},
                {"Estrutura Continue - Estruturas de Controle", EstruturaContinue.Executar},
                //Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos EStaticos - Classes e Metodos", MetodosStaticos.Executar},
                {"Atributos EStaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get e Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct x Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Valor x Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametros Por Valor Padrão - Classes e Metodos", ParametroPadrao.Executar},
                
                //Coleções
                {"Array - Coleções", Udemy.Colecoes.Array.Executar},
                {"ArrayList - Coleções", MyArrayList.Executar},
                {"Lista - Coleções", Lista.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"MyQueue - Coleções", MyQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecaoStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                {"Herança - OO", Udemy.OO.Carro.Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", Udemy.OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Metodos E Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Exemplo Lambdas como Delegates - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate Func Anonima - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegates como Parametros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Metodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                //Excecoes
                {"Primeira Excecao - Excecoes", PrimeiraExcecao.Executar},
                {"Excecoes Personalizadas - Excecoes", ExcecoesPersonalizadas.Executar},

                //API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - API", LendoArquivos.Executar},
                {"File Info - API", ExemploFileInfo.Executar},

                //Topicos Avançados
                {"Linq1 - Tópicos Avançados", LINQ1.Executar},
                {"Linq2 - Tópicos Avançados", LINQ2.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}
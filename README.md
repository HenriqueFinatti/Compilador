# Compilador

## Lista De Tokens
O compilador aceita os seguintes tipos de tokens
- **Id:** [a-z A-Z _ ][a-z A-Z 0-9 _]*
- **Palavras Reservadas:** (int | char | string | double | bool | void | for | while | if | input | output)
- **Operadores Logicos:** (AND | OR | NOT)
- **Operadores Matematicos:** (+ | - | / | * | %)
- **Operadores Relacionais:** (>= | <= | != | = | > | <)
- **Operador Atribuição:** <-
- **Valores Inteiros:** [0-9]+
- **Valores Caracteres:** '.*'
- **Valores String:** ".*"
- **Valores Double:** [0-9]+.[0-9]+
- **Valores Booleanos:** (true | false)
- **Parenteses Aberto:** (
- **Parenteses Fechado:** )
- **Chaves Aberta:** {
- **Chaves Fechada:** }
- **Fim de Instrução:** ;
- **Comentários:** & .*
- **Incremento:** ++
- **Decremento:** --
- **Controle De String:** ,
```
void introducao(){
	output("Esse é um exemplo de código do meu compilador");
}
int void main(){
	int a <- 0;
	char b <- 'b';
	string c <- "c";
	double d <- 1.1;
	bool e <- false;

	introducao();

	for(int i <- 0; i < 10; i++){
		output("Valor do i", i, ".");
	}

	if(a = 0 AND b = 'b'){
		output("X");
	}
	else if(c = "c"){
		output("X");
	}
	else{
		output(d);
	}
}
```
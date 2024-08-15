# Conversor de Temperatura 

### Esse código em C# implementa um conversor de temperaturas que converte uma temperatura fornecida em graus Celsius para Fahrenheit e Kelvin. 

### Abaixo está uma explicação detalhada do código:


**Declaração de variáveis:**

* Três variáveis de tipo double são declaradas: c (para armazenar a temperatura em Celsius), f (para armazenar a conversão para Fahrenheit), e k (para armazenar a conversão para Kelvin).

~~~~
double c, f, k;
~~~~


**Exibição de mensagens:**

* O programa exibe o título "Conversor de Temperaturas" e uma linha de separação.

~~~~
Console.WriteLine(" Conversor de Temperaturas ");
Console.WriteLine("--------------------------------------------------");
~~~~

**Entrada de temperatura em Celsius:**

* O programa pede ao usuário para inserir a temperatura em Celsius e a armazena na variável c. O método double.Parse converte o valor digitado, que originalmente é uma string, em um número do tipo double.

~~~~
Console.Write("Insira a temperatura em Celsius: ");
c = double.Parse(Console.ReadLine());
Console.WriteLine("--------------------------------------------------");
~~~~


**Conversão para Fahrenheit:**

* A temperatura em Celsius é convertida para Fahrenheit usando a fórmula:

~~~~
f = (c * 9 / 5) + 32;
~~~~

**Conversão para Kelvin:**

* A temperatura em Celsius é convertida para Kelvin pela fórmula:

~~~~
k = c + 273.15;
~~~~

**Exibição dos resultados:**

* O programa exibe os valores convertidos para Fahrenheit e Kelvin.
  
~~~~
Console.WriteLine(c + " Graus Celsius = " + f + " Graus em Fahrenheit");
Console.WriteLine(c + " Graus Celsius = " + k + " Graus em Kelvin");
Console.WriteLine("--------------------------------------------------");
~~~~

**Pausa antes de fechar o programa:**

* O programa aguarda o usuário pressionar uma tecla para finalizar, dando tempo ao usuário para ver os resultados antes que o console seja fechado.
  
~~~~
Console.ReadKey();
~~~~


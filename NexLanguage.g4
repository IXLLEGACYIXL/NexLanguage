grammar NexLanguage;

@parser::namespace{MyCompiler}

program: (declaration | assignment)+ ;

declaration: datatype ID ';' ;

assignment: ID '=' datatype '(' ')' ';' ;

datatype: 'int' | 'Int32' ;

ID: [a-zA-Z]+ ;

WS: [ \t\r\n]+ -> skip ;
# csChess

## But du projet :
Le but est de créer un jeu d'échec qui soit extensible au niveau de ses règles, du plateau, des pièces etc.
L'architecture sera donc pensé pour être ouverte à l'extension.

## Les différentes parties :
Le projet est divisé en deux parties :

	- chessGame : ce dossier contient tous les codes qui sont relatif au jeu.
	
	- chessGameTests : ici sont placés les tests des différentes classes, principalement du modèle.

### Organisation du dossier chessGame :
utils : contiend et est destiné à contenir des classes ayant des tâches utilitaires pour l'ensemble du projet (comme stocker l'ensemble des textes qui devront être affiché afin d'éviter que cela ne soit hardcodé).

Le model contient l'ensemble dse classes permettant de créer des objets qui interviendront durant le jeu, c'est à dire des classes permettant de créer les objets à afficher sur le plateau et qui feront partie du jeu. Il est divisé actuellement en trois parties :

	- board : contient tout ce qui est relatif au plateau, c'est à dire les cooordonées, un pattern builder permettant de simplifier la création du baord et d'en fournir une abstraction, et le board.	
	
	- game : contient les classes qui sont plus lié à une partie en cours, au jeu de manière générale.
	
	- piece : relatif à ce qui concerne les pièces (classe absrtaite, implémentation concrète, enum etc.).

## Tests :
Les tests quant a eux seront dans un projet à part car géré comme cela par visual studio. Il contient les différents tests liée au model dans des dossiers correspondant au classes dont ils implémentent le test des méthodes.
L'ensemble des méthodes sont testées à l'execeptions de test triviaux (comme test de getter/setter) et d'objet simple comme "Player".

## Points importants :
	- De nouvelles pièces peuvent être crées comme objet grâce à une classe abstraite se trouvant dans Piece, fournissant l'ensemble des méthodes à implémenter ou en fournissant des comportements de base.
	- Un builder dans le dossier "board" est la pour simplifier la création du board en fournissant une abstraction de sa création et un director permet de montrer comment le construire facilement dans le cas ou il faudrait créer un autre board, ou le changer.

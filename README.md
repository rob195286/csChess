# csChess

Le but du projet :

Le but est de créer un jeu d'échec qui soit extensible au niveau de ses règles, du plateau, des pièces etc.
L'architecture sera donc pensée pour être ouverte à l'extension.

Caractéristiques :

Le projet est divisé en deux dossiers :
	- utils : qui contiend et est destiné à contenir des classes ayant des tâches utilitaire pour l'ensemble du projet 
			(comme stocker l'ensemble des messages qui devront être affichés et éviter que cela ne soit hardcodé).
	- model : contient l'ensemble du model, c'est à dire des classes permettant de créer les objets à afficher, qui feront
			partie du jeu.
Des pièces peuvent êtres ajoutées grâce à une classe abstraite se trouvan dans .
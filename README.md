--- DESCRIPTION ---

Projet 3D personnel qui est un prototype RTS (Real Time Strategy) solo s’inscrivant dans un univers médiéval. 
Le joueur devra développer sa colonie, faire prospérer son peuple et le défendre face aux attaques de pillards.


--- CONTROLES ---


Flèches directionnelles (↓↑←→) : Déplacer la caméra

Molette souris : Zoom caméra

Molette souris(rester appuyé) : Rotation caméra

T : Construire une maison (Temporaire/Pour tests)

Clique gauche : Sélectionne unité(militaire)

Clique droit(unité(s) sélectionnée(s)) : Déplacement seul ou en groupe(formation)

Clique droit(unité(s) militaire(s) sélectionnée(s)) sur cible ennemie : Commande d'attaque



--- ACHEVÉ ---

- Ajout gestion de la Caméra
- Ajout sélection simple et multiple d'unité
- Déplacement d’une ou plusieurs unités (via Navmesh)
- Bases du mode construction. Proposition placement avec contrôle du terrain puis placement (à finir)
- Modèle Soldat + armes(première unité de combat) + animations(Attente, course, garde et attaque) via Blender
- Système de combat rapproché (+ Détection d’ennemi et suivi, automatiquement ou sur commande du joueur)
- Ajout du curseur "de base" ainsi que le curseur de combat (indicateur pour le joueur)
- Positionnement(formation) des unités suite à un déplacement en groupe
- Logique de récolte du bois (Sera également utilisé pour la récolte de la pierre et du fer)
- Modèle(+ animation d'attente, de marche, de coupe et de transport de rondin) d'une nouvelle unité via Blender, le bûcheron (+ hache)
- Modèle arbre + animation(chute)
- Modèle(basique) du camp de bûcheron, du hall (bâtiment principal) et de l'entrepôt
- Gestion(via UI) de la main d’œuvre du camp de bûcheron(Logger Camp)
- Logique de récolte de la pierre (légèrement différent de la récolte du bois)
- Animation minage du mineur de pierre
- Modèle rocher
- Modèle cabane de mineur de pierre
- Gestion(via UI) de la main d’œuvre de la cabane de mineur de pierre(Logger Camp)
- Système de construction (sur terrain plat) + UI(menu de construction)

--- PRÉVISIONS ---
- Modélisation(et import) + config + UI de la caserne(permettra recrutement de soldat) : en cours
- Modélisation(et import) + config + UI de la mine d'or
- Modélisation(et import) + config + UI de la ferme
- Amélioration logique de combat pour permettre l'attaque de bâtiments (sera utilisé pour les pillards)
  


--- OUTILS ---

- Unity
- Blender
- Visual Studio(C#)



--- SOURCES ---

[Make RTS (Mike)](https://www.youtube.com/watch?v=-GfdKB_7mrY&list=PLtLToKUhgzwkCRQ9YAOtUIDbDQN5XXVAs)

[Navmesh (Tuto Unity FR)](https://www.youtube.com/watch?v=qOQVxPQ-C5Y&t=489s)

[Unity - changer le curseur de la souris(MakeYourGame)](https://www.youtube.com/watch?v=qifz_CXe4CQ&t=321s)

[Documentation Unity](https://docs.unity3d.com/Manual/index.html)


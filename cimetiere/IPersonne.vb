Public Interface IPersonne
    ' chaque classe qui représente un personne implémente cette interface indépendamment, ça fait beaucoup de c/c mais avec l'entity framework c'est compliqué de faire un héritage
    Property Id As Integer
    Property Nom As String
    Property Prenom As String
    Property Adresse As String
    Property Pays As Pays
    Property LocVille As LocVille            ' ville et pays étant toujours liés (même si l'un des éléments de la paire, voire les deux), on ne peut pas seilement changer la ville et le pays, mais seulement la paire, et pour bien faire il faut éviter d'en créer une qui existe déjà
    ''Property VillePays As VillePays 'À FAIRE
    Property Cp As Integer?
    Property NomVille As String
    Property NomPays As String
    ReadOnly Property AdresseComplete As String
    ReadOnly Property NomComplet As String
End Interface

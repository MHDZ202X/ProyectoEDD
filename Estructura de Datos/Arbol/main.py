from arbol_bin import arbolbin

tree = arbolbin()

tree.add(10)
tree.add(56)
tree.add(5)
tree.add(8)
tree.add(78)
tree.add(56)
tree.add(54)
tree.add(35)

tree.show_in_order(tree.root)
tree.show_pos_order(tree.root)
tree.show_pre_order(tree.root)

print(tree.search(tree.root,78).is_root)
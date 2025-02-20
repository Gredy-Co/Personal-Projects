<!-- Main container for the species list page -->
<div class="container mr-0 mt-10 px-4">
    <!-- Header section for the page -->
    <div class="bg-white shadow-lg rounded-lg p-4 max-w-4xl ml-80">
        <div class="text-center">
            <!-- Page title -->
            <h1 class="text-6xl font-bold text-center">Administrar Especies</h1>
            <!-- Description of the page -->
            <p class="text-gray-600 mt-2 text-center">Aquí hay una lista de todas las especies registradas.</p>

            <!-- Button linking to the species registration page -->
            <div class="flex justify-center space-x-4 mt-4">
                <a href="/admin/showaddspecies" class="bg-green-500 text-white px-4 py-2 rounded hover:bg-green-600">Añadir Especie</a>
            </div>

            <!-- Button linking to the species list page -->
            <div class="flex justify-center space-x-4 mt-4">
                <a href="/admin/dashboard" class="bg-blue-500 text-white px-4 py-2 rounded hover:bg-green-600">Página Principal</a>
            </div>
        </div>
    </div>

    <!-- Display error message if there is one -->
    <?php if (isset($error_msg)) : ?>
        <div class="bg-red-500 text-white text-center py-2 mt-4 rounded max-w-4xl mx-auto">
            <?= htmlspecialchars($error_msg) ?>
        </div>
    <?php endif; ?>

    <!-- Table section to display the list of species -->
    <div class="mt-5 max-w-4xl ml-80 overflow-hidden">
        <table class="min-w-full bg-white shadow-md rounded-lg overflow-hidden w-full">
            <!-- Table header -->
            <thead>
                <tr class="bg-blue-200 text-gray-700 text-center">
                    <th class="px-6 py-3 text-center">ID Especie</th>
                    <th class="px-6 py-3 text-center">Nombre Comercial</th>
                    <th class="px-6 py-3 text-center">Nombre Científico</th>
                    <th class="px-6 py-3 text-center">Editar</th>
                    <th class="px-6 py-3 text-center">Eliminar</th>
                </tr>
            </thead>
            <tbody>
                <!-- Check if there are any species available to display -->
                <?php if (!empty($species)) : ?>
                    <!-- Loop through each species and display its details -->
                    <?php foreach ($species as $specie) : ?>
                        <tr class="border-b"
                            <!-- Display the specie ID -->
                            <td class="text-center px-6 py-4"><?= htmlspecialchars($specie['Id_Specie']) ?></td>
                            <!-- Display the commercial name of the specie -->
                            <td class="px-6 py-4"><?= htmlspecialchars($specie['Commercial_Name']) ?></td>
                            <!-- Display the scientific name of the specie -->
                            <td class="px-6 py-4"><?= htmlspecialchars($specie['Scientific_Name']) ?></td>

                            <!-- Edit link to the specie update page -->
                            <td class="px-6 py-4 text-center">
                                <a href="/admin/showupdatespecies?id_specie=<?= urlencode($specie['Id_Specie']) ?>" 
                                class="bg-yellow-500 text-white px-3 py-1 rounded hover:bg-yellow-600 flex items-center justify-center space-x-2" 
                                title="Edit">
                                    <i class="fa-solid fa-pen-to-square"></i>
                                    <span>Editar</span>
                                </a>
                            </td>
                            
                            <!-- Delete form to delete the specie -->
                            <td class="px-6 py-4 text-center">
                                <form action="/admin/deletespecies" method="POST" style="display:inline;" title="Delete">
                                    <input type="hidden" name="id_specie" value="<?= $specie['Id_Specie'] ?>">
                                    <button type="submit" class="bg-red-500 text-white px-3 py-1 rounded hover:bg-red-600 flex flex-col items-center" onclick="return confirm('Are you sure you want to delete this specie?');">
                                        <i class="fa-solid fa-trash"></i> Eliminar
                                    </button>
                                </form>
                            </td>
                        </tr>
                    <?php endforeach; ?>
                <?php else : ?>
                    <tr>
                        <td colspan="5" class="text-center text-gray-500 py-4">No se encontraron especies</td>
                    </tr>
                <?php endif; ?>
            </tbody>
        </table>
    </div>
</div>

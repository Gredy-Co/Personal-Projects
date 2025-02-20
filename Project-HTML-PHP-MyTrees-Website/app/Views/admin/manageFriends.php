<?php
    $roleId = session()->get('role_id'); 
?>

<!-- Include Alpine.js for possible JavaScript functionality (e.g., modal windows or dynamic content) -->
<script src="https://cdn.jsdelivr.net/npm/alpinejs@3.4.2/dist/cdn.min.js" defer></script>

<!-- Main container for the species list page -->
<div class="container mr-0 mt-10 px-4">
    <!-- Header section for the page -->
    <div class="bg-white shadow-lg rounded-lg p-4 max-w-4xl ml-80">
        <div class="text-center">
            <!-- Page title with green color and centered text -->
            <h1 class="text-6xl font-bold text-600 tracking-tight">Administrar árboles de amigos</h1>
            <!-- Description of the page -->
            <p class="text-gray-600 mt-2">Aquí hay una lista de todos los árboles registrados.</p>

            <!-- Button linking to the trees list page -->
            <div class="text-center">
                <?php if ($roleId == 1): ?>
                    <a href="/admin/dashboard" class="bg-blue-500 text-white px-4 py-2 rounded hover:bg-blue-600 mt-3 inline-block">Ir al Inicio</a>
                <?php else: ?>
                    <a href="/operator/dashboard" class="bg-blue-500 text-white px-4 py-2 rounded hover:bg-blue-600 mt-3 inline-block">Ir al Inicio</a>
                <?php endif; ?>
            </div>
        </div>
    </div>

    <!-- Display error message if there is one -->
    <?php if (isset($error_msg)) : ?>
        <div class="bg-red-500 text-white py-2 mt-4 rounded max-w-4xl ml-auto text-right">
            <?= htmlspecialchars($error_msg) ?>
        </div>
    <?php endif; ?>

    <!-- Table section to display the list of friends -->
    <div class="mt-5 max-w-4xl ml-80 overflow-hidden">
        <table class="min-w-full bg-white shadow-md rounded-lg overflow-hidden w-full">
            <!-- Table header -->
            <thead>
                <tr class="bg-blue-200 text-gray-700 text-center">
                    <th scope="col" class="px-6 py-3 text-center">Foto de Perfil</th>
                    <th scope="col" class="px-6 py-3 text-center">Nombre</th>
                    <th scope="col" class="px-6 py-3 text-center">Apellido</th>
                    <th scope="col" class="px-6 py-3 text-center">Nombre de Usuario</th>
                    <th scope="col" class="px-6 py-3 text-center">Correo Electrónico</th>
                    <th scope="col" class="px-6 py-3 text-center">Ver Árboles</th>
                </tr>
            </thead>
            <tbody>
                <!-- Check if users are available to display -->
                <?php if (!empty($users)) : ?>
                    <!-- Loop through each user and display their data -->
                    <?php foreach ($users as $user) : ?>
                        <tr class="border-b text-center">
                            <!-- Display the user's profile picture if available -->
                            <td class="text-center px-6 py-4">
                                <?php if (!empty($user['Profile_Pic'])) : ?>
                                    <?php
                                        // Generate the URL for the profile image with a cache-busting query string
                                        $image_url = htmlspecialchars($uploads_folder . $user['Profile_Pic']) . '?' . time();
                                    ?>
                                    <!-- Display the profile image as a circular thumbnail -->
                                    <img src="<?= $image_url; ?>" alt="Profile Picture" class="rounded-full w-12 h-12 mx-auto">
                                <?php else : ?>
                                    <span class="text-gray-400">No Imagen</span>
                                <?php endif; ?>
                            </td>
                            <td class="px-6 py-4"><?= htmlspecialchars($user['First_Name']) ?></td>
                            <td class="px-6 py-4"><?= htmlspecialchars($user['Last_Name1']) ?></td>
                            <td class="px-6 py-4"><?= htmlspecialchars($user['Username']) ?></td>
                            <td class="px-6 py-4"><?= htmlspecialchars($user['Email']) ?></td>

                            <td class="px-6 py-4 text-center">
                                <a href="showfriendtrees?id_user=<?= urlencode($user['Id_User']) ?>" 
                                class="bg-yellow-500 text-white px-3 py-1 rounded hover:bg-yellow-600 flex items-center justify-center space-x-2" 
                                title="View Trees">
                                    <i class="fas fa-tree"></i>
                                    <span>Ver Árboles</span>
                                </a>
                            </td>
                        </tr>
                    <?php endforeach; ?>
                <?php else : ?>
                    <tr>
                        <td colspan="5" class="text-center text-gray-500 py-4">No se encontraron usuarios</td>
                    </tr>
                <?php endif; ?>
            </tbody>
        </table>
    </div>
</div>

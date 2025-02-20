<body class="bg-white-300 font-sans">
    <div class="min-h-screen flex items-center justify-center">
        <!-- Card Container -->
        <div class="bg-white w-full max-w-7xl p-16 rounded-lg shadow-lg flex flex-col justify-between min-h-screen"> <!-- Fondo blanco ocupando toda la pantalla -->
            <!-- Header -->
            <div class="mb-6 ml-60">
                <h1 class="text-4xl font-bold text-gray-800">Crear un nuevo usuario</h1>
                <p class="text-gray-600 text-sm">Insertar los datos de la persona</p>
            </div>

            <!-- General Error Message -->
            <?php if (session()->get('error')): ?>
                <div class="bg-red-500 text-white py-2 mt-4 rounded max-w-4xl ml-80">
                    <ul>
                        <?php foreach (session('error') as $field => $error): ?>
                            <li><?= esc($error) ?></li>
                        <?php endforeach; ?>
                    </ul>
                </div>
            <?php endif; ?>

            <!-- Form -->
            <form method="POST" action="/admin/adduser" enctype="multipart/form-data" class="space-y-4">
                <?= csrf_field() ?>

                <!-- Profile Picture -->
                <div class="flex flex-col items-center space-y-4 -ml-80">
                    <div class="relative">
                        <img id="previewImage" src="img/default_profile.png" alt="Profile Picture" class="w-24 h-24 rounded-full shadow-md">
                        <label for="profilePic" class="absolute bottom-0 right-0 bg-blue-500 text-white p-2 rounded-full cursor-pointer hover:bg-blue-600">
                            <i class="fas fa-camera"></i>
                        </label>
                    </div>
                    <input type="file" name="profilePic" id="profilePic" accept="image/png, image/jpeg" class="hidden">
                </div>

                <!-- First Name -->
                <div class="ml-60">
                    <label for="first_name" class="block text-sm font-medium text-gray-700">Nombre</label>
                    <input id="first_name" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" type="text" name="first_name" value="<?= old('first_name') ?>" required>
                    <div class="text-red-500 text-sm"><?= session('error')['first_name'] ?? '' ?></div>
                </div>

                <!-- Last Name 1 -->
                <div class="ml-60"> 
                    <label for="last_name1" class="block text-sm font-medium text-gray-700">Primer Apellido</label>
                    <input id="last_name1" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" type="text" name="last_name1" value="<?= old('last_name1') ?>" required>
                    <div class="text-red-500 text-sm"><?= session('error')['last_name1'] ?? '' ?></div>
                </div>

                <!-- Last Name 2 -->
                <div class="ml-60"> 
                    <label for="last_name2" class="block text-sm font-medium text-gray-700">Segundo Apellido</label>
                    <input id="last_name2" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" type="text" name="last_name2" value="<?= old('last_name2') ?>" required>
                    <div class="text-red-500 text-sm"><?= session('error')['last_name2'] ?? '' ?></div>
                </div>

                <!-- Email -->
                <div class="ml-60"> 
                    <label for="email" class="block text-sm font-medium text-gray-700">Correo Electrónico</label>
                    <input id="email" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" type="email" name="email" value="<?= old('email') ?>" required>
                    <div class="text-red-500 text-sm"><?= session('error')['email'] ?? '' ?></div>
                </div>

                <!-- Phone -->
                <div class="ml-60">
                    <label for="phone" class="block text-sm font-medium text-gray-700">Teléfono</label>
                    <input id="phone" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" type="text" name="phone" value="<?= old('phone') ?>" required>
                    <div class="text-red-500 text-sm"><?= session('error')['phone'] ?? '' ?></div>
                </div>

                <!-- Gender -->
                <div class="ml-60">
                    <label for="gender" class="block text-sm font-medium text-gray-700">Género</label>
                    <select id="gender" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" name="gender" required>
                        <option value=""    <?= old('gender') === '' ? 'selected' : '' ?>>Selecciona el género</option>
                        <option value="M"   <?= old('gender') === 'M' ? 'selected' : '' ?>>Masculino</option>
                        <option value="F"   <?= old('gender') === 'F' ? 'selected' : '' ?>>Femenino</option>
                        <option value="O"   <?= old('gender') === 'O' ? 'selected' : '' ?>>Otro</option>
                    </select>
                    <div class="text-red-500 text-sm"><?= session('error')['gender'] ?? '' ?></div>
                </div>

                <!-- Country -->
                <div class="ml-60"> 
                    <label for="country" class="block text-sm font-medium text-gray-700">País</label>
                    <select id="country" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" name="country" required>
                        <?php foreach ($country as $countries): ?>
                            <option value="<?= $countries['Id_Country'] ?>" <?= old('country') == $countries['Id_Country'] ? 'selected' : '' ?>><?= $countries['Country_Name'] ?></option>
                        <?php endforeach; ?>
                    </select>
                    <div class="text-red-500 text-sm"><?= session('error')['country'] ?? '' ?></div>
                </div>

                <!-- Province -->
                <div class="ml-60">
                    <label for="province" class="block text-sm font-medium text-gray-700">Provincia</label>
                    <select id="province" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" name="province" required>
                        <?php foreach ($province as $provinces): ?>
                            <option value="<?= $provinces['Id_Province'] ?>" <?= old('province') == $provinces['Id_Province'] ? 'selected' : '' ?>><?= $provinces['Province_Name'] ?></option>
                        <?php endforeach; ?>
                    </select>
                    <div class="text-red-500 text-sm"><?= session('error')['province'] ?? '' ?></div>
                </div>

                <!-- District -->
                <div class="ml-60">
                    <label for="district" class="block text-sm font-medium text-gray-700">Distrito</label>
                    <select id="district" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" name="district" required>
                        <?php foreach ($district as $districts): ?>
                            <option value="<?= $districts['Id_District'] ?>" <?= old('district') == $districts['Id_District'] ? 'selected' : '' ?>><?= $districts['District_Name'] ?></option>
                        <?php endforeach; ?>
                    </select>
                    <div class="text-red-500 text-sm"><?= session('error')['district'] ?? '' ?></div>
                </div>

                <!-- Username -->
                <div class="ml-60">
                    <label for="username" class="block text-sm font-medium text-gray-700">Nombre de usuario</label>
                    <input id="username" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" type="text" name="username" value="<?= old('username') ?>" required>
                    <div class="text-red-500 text-sm"><?= session('error')['username'] ?? '' ?></div>
                </div>

                <!-- Password -->
                <div class="ml-60">
                    <label for="password" class="block text-sm font-medium text-gray-700">Contraseña</label>
                    <input id="password" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" type="password" name="password" required>
                    <div class="text-red-500 text-sm"><?= session('error')['password'] ?? '' ?></div>
                </div>

                <!-- Role -->
                <div class="ml-60">
                    <label for="role" class="block text-sm font-medium text-gray-700">Rol</label>
                    <select id="role" class="block w-full mt-1 border-gray-300 rounded-md shadow-sm focus:ring-blue-500 focus:border-blue-500" name="role" required>
                        <option value=""    <?= old('role') === '' ? 'selected' : '' ?>>Seleccionar rol de usuario</option>
                        <option value="1"   <?= old('role') === '1' ? 'selected' : '' ?>>Administrador</option>
                        <option value="3"   <?= old('role') === '3' ? 'selected' : '' ?>>Operador</option>
                    </select>
                    <div class="text-red-500 text-sm"><?= session('error')['role'] ?? '' ?></div>
                </div>

                <!-- Submit Button -->
                <button type="submit" class="w-40 bg-blue-500 ml-60 text-white py-1 px-4 rounded-lg shadow-md hover:bg-blue-600 focus:outline-none focus:ring-2 focus:ring-blue-400 focus:ring-opacity-75">
                    Añadir Usuario
                </button>

                <!-- Back to Manage Species -->
                <a href="manageusers" 
                    class="w-40 bg-blue-500 ml-60 text-white py-1 px-4 rounded-lg shadow-md hover:bg-blue-600 focus:outline-none focus:ring-2 focus:ring-blue-400 focus:ring-opacity-75">
                    Administrar Usuarios
                </a>
            </form>
        </div>
    </div>
</body>

<!-- jQuery (required for AJAX) -->
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script>
    // Profile picture preview when the user selects a new image
    $('#profilePic').on('change', function(event) {
        var reader = new FileReader();
        reader.onload = function(e) {
            $('#previewImage').attr('src', e.target.result);  // Set the image in the preview container
        };
        reader.readAsDataURL(this.files[0]);  // Read the selected image
    });

    $(document).ready(function() {
        // Event when the country select changes, triggering AJAX to get provinces
        $('#country').on('change', function() {
            var countryId = $(this).val();  // Get the selected country ID

            // If a country is selected, make the AJAX request
            if (countryId) {
                $.ajax({
                    url: '/user/getProvinces',  // URL for getting provinces based on the country
                    type: 'POST',
                    data: { country_id: countryId },
                    dataType: 'json',  // Expect a JSON response
                    success: function(data) {
                        if (data.options) {
                            $('#province').html(data.options);  // Update the provinces dropdown
                        } else {
                            $('#province').html('<option value="">' + data.message + '</option>');  // Show message if no provinces found
                        }
                    },
                    error: function(xhr, status, error) {
                        alert('Error loading provinces: ' + error);  // Show error if the request fails
                    }
                });
            } else {
                $('#province').html('<option value="">Select Province</option>');  // Reset the provinces dropdown
            }
        });

        // Event when the province select changes, triggering AJAX to get districts
        $('#province').on('change', function() {
            var provinceId = $(this).val();  // Get the selected province ID

            // If a province is selected, make the AJAX request
            if (provinceId) {
                $.ajax({
                    url: '/user/getDistricts',  // URL for getting districts based on the province
                    type: 'POST',
                    data: { province_id: provinceId },
                    dataType: 'json',  // Expect a JSON response
                    success: function(data) {
                        if (data.options) {
                            $('#district').html(data.options);  // Update the districts dropdown
                        } else {
                            $('#district').html('<option value="">' + data.message + '</option>');  // Show message if no districts found
                        }
                    },
                    error: function(xhr, status, error) {
                        alert('Error loading districts: ' + error);  // Show error if the request fails
                    }
                });
            } else {
                $('#district').html('<option value="">Select District</option>');  // Reset the districts dropdown
            }
        });
    });
</script>


<body class="font-sans bg-gray-100">
    <header>
        <nav class="fixed top-0 left-0 h-full w-64 bg-gray-300 shadow-lg flex flex-col p-4 z-50">
            <a href="#" id="profile-link" class="flex flex-col items-center mb-8 p-4 bg-gray-300 rounded-lg hover:bg-green-500 hover:text-white transition duration-300">
                <img src="<?= $uploads_profile . $profilePic . '?' . time() ?>" alt="Profile Image" class="w-20 h-20 rounded-full border-4 border-white mb-3 object-cover">
                <div class="text-center font-semibold text-gray-700"><?php echo htmlspecialchars($_SESSION['username']); ?></div>
            </a>
            <div id="profile-submenu" class="hidden flex-col p-4 space-y-2"> 
               <!-- Profile button -->
               <a href="/showupdateuser" class="text-gray-800 hover:text-white hover:bg-green-500 px-4 py-2 rounded flex items-center space-x-2 w-full">
                    <i class="fas fa-user-circle"></i>
                    <span>Perfil</span>
                </a>
                <form action="/user/logout" method="post">
                    <button type="submit" class="text-gray-800 hover:text-white hover:bg-green-500 px-4 py-2 rounded flex items-center space-x-2 w-full">
                        <i class="fas fa-sign-out-alt"></i>
                        <span>Cerrar Sesión</span>
                    </button>
                </form>
            </div>
            <ul class="space-y-4">
                <li>
                    <a href="/admin/dashboard" class="flex items-center px-4 py-2 text-gray-800 bg-gray-300 rounded-lg hover:bg-green-500 hover:text-white transition duration-300">
                        <i class="fas fa-home mr-3"></i> Inicio
                    </a>
                </li>
                <li>
                    <a href="/admin/manageusers" class="flex items-center px-4 py-2 text-gray-800 bg-gray-300 rounded-lg hover:bg-green-500 hover:text-white transition duration-300">
                        <i class="fas fa-home mr-3"></i> Administrar Usuarios
                    </a>
                </li>
                <li>
                    <a href="/admin/managespecies" class="flex items-center px-4 py-2 text-gray-800 bg-gray-300 rounded-lg hover:bg-green-500 hover:text-white transition duration-300">
                        <i class="fas fa-tree mr-3"></i> Administrar Especies
                    </a>
                </li>
                <li>
                    <a href="/admin/managetrees" class="flex items-center px-4 py-2 text-gray-800 bg-gray-300 rounded-lg hover:bg-green-500 hover:text-white transition duration-300">
                        <i class="fas fa-tree mr-3"></i> Administrar Árboles
                    </a>
                </li>
                <li>
                    <a href="/managefriends" class="flex items-center px-4 py-2 text-gray-800 bg-gray-300 rounded-lg hover:bg-green-500 hover:text-white transition duration-300">
                        <i class="fas fa-tree mr-3"></i> Administrar Árboles de Amigos
                    </a>
                </li>
            </ul>
        </nav>
    </header>
</body>
<script>
        document.getElementById('profile-link').addEventListener('click', function(event) {
            event.preventDefault();  
            const submenu = document.getElementById('profile-submenu');
            submenu.classList.toggle('hidden'); 
        });

        window.onscroll = function() {
            let winScroll = document.body.scrollTop || document.documentElement.scrollTop;
            let height = document.documentElement.scrollHeight - document.documentElement.clientHeight;
            let scrolled = (winScroll / height) * 100;
            document.getElementById('progress-bar').style.width = scrolled + "%"; 
        };
    </script>
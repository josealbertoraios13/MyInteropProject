cmake_minimum_required(VERSION 3.10)
project(native)

# 1. Compila o seu código C como uma biblioteca estática
add_library(core STATIC core/src/math.c)
target_include_directories(core PUBLIC core/include)

set_target_properties(core PROPERTIES POSITION_INDEPENDENT_CODE ON)

# 2. Compila o seu C++ e a ponte (export) como uma biblioteca dinâmica (SHARED)
# É essa biblioteca compartilhada que o C# vai enxergar
add_library(wrapper SHARED wrapper/src/math.cpp wrapper/src/export_math.cpp)
target_include_directories(wrapper PUBLIC wrapper/include)

# 3. Informa ao CMake que o wrapper precisa das funções do core
target_link_libraries(wrapper PRIVATE core)